using System;
using System.Threading;
using System.Net.NetworkInformation;

namespace PingTester
{
    // Enums    
    public enum State { Unknown, Success, Failure, Transient}

    // Event arguments    
    public class PingPerformerEventArgs : EventArgs
    {
        public State State       { get; private set;}
        public string Message       { get; private set;}
        
        public PingPerformerEventArgs(State state, string message)
        {
            this.State = state;
            this.Message = message;
        }
    }
    
    // Delegates    
    public delegate void StateChangeHandler(PingPerformer sender, PingPerformerEventArgs e);
    public delegate void ReplyRecievedHandler(PingPerformer sender, PingPerformerEventArgs e);

    // PingPerformer class
    public class PingPerformer
    {
        // Members
        private string destinationName;
        private string destinationAddress;
        private int timeToLive;
        private int bufferSize;
        private byte[] buffer;
        private bool dontFragment;
        private int timeoutDelay;
        private int pingInterval;
        private int sequentNumber;
        private int stabilityCount;
        private int distanceToLastFail;
        private State state;
        private Thread runThreadHandler;
        private bool run = false;
        private bool stopped = false;
        private bool isStopping = false;
        private ulong successfullPingsCount;
        private ulong failedPingsCount;
        private object _locker = new object();

        public object Container = null;

        // Events
        public event StateChangeHandler StateChanged;
        public event ReplyRecievedHandler ReplyRecieved;
                


        public PingPerformer(string destinationSiteName, string destinationIPAddress,
            int stabilityCount, int timeToLive, int bufferSize, bool dontFragment, 
            int timeoutDelay, int pingInterval)
        {
            if (stabilityCount < 0)
                stabilityCount = 0;            
            if (timeoutDelay < 10)
                timeoutDelay = 10;
            if (timeToLive < 1)
                timeToLive = 1;
            if (timeToLive > 255)
                timeToLive = 255;
            if (bufferSize < 1)
                bufferSize = 1;
            if (pingInterval < 10)
                pingInterval = 10;
            if (pingInterval > 10000)
                pingInterval = 10000;

            this.timeToLive = timeToLive;
            this.bufferSize = bufferSize;
            this.buffer = new byte[bufferSize];
            this.dontFragment = dontFragment;
            this.timeoutDelay = timeoutDelay;
            this.pingInterval = pingInterval;
            this.destinationName = destinationSiteName;
            this.destinationAddress = destinationIPAddress;
            this.stabilityCount = stabilityCount;
            this.distanceToLastFail = int.MaxValue;
            this.state = State.Unknown;            
            this.sequentNumber = 0;

            this.successfullPingsCount = 0;
            this.failedPingsCount = 0;
        }


        public void ChangeSettings(int stabilityCount, int timeToLive, int bufferSize, bool dontFragment,
            int timeoutDelay, int pingInterval)
        {            
            this.timeToLive = timeToLive;
            this.bufferSize = bufferSize;
            this.buffer = new byte[bufferSize];
            this.dontFragment = dontFragment;
            this.timeoutDelay = timeoutDelay;
            this.pingInterval = pingInterval;
            this.stabilityCount = stabilityCount;
            this.distanceToLastFail = int.MaxValue;
            this.state = State.Unknown;            
        }


        public void Start()
        {
            lock (_locker) {
                // Don't start anything if it's already running
                if (this.run == true)
                    return;

                this.run = true;
                this.isStopping = false;
                this.stopped = false;
                this.runThreadHandler = new Thread(new ThreadStart(this.RunThread));
                this.runThreadHandler.IsBackground = true;
                this.runThreadHandler.Start();
            }
        }

        public void Stop()
        {
            lock (_locker) {
                if (this.runThreadHandler == null)
                    return;

                this.run = false;
                this.runThreadHandler.Join();

                this.state = State.Unknown;
                this.stopped = true;
            }
        }

        public void BeginStop()
        {
            this.isStopping = true;
            Thread t = new Thread(new ThreadStart(this.Stop));
            t.IsBackground = true;
            t.Start();
        }

        public void ResetStatistics()
        {
            this.successfullPingsCount = 0;
            this.failedPingsCount = 0;
        }



        private void Successed()
        {
            // Increment the distance from the last failure. Not nessecary if the distance is
            // already greater than watchedRepliesCount (due to lots of successes)
            if (this.distanceToLastFail <= this.stabilityCount) {
                this.distanceToLastFail++;
            }

            // Increase number of successfull pings
            this.successfullPingsCount++;

            // Check to see if the state should be changed
            if (this.distanceToLastFail < this.stabilityCount && this.state != State.Transient) {
                // If the distance is less then watchedRepliesCount then our state should be Transient.
                // If it's not, change it and raise an event. Usually accure in the 
                // first successful attemt after a faliure.

                this.state = State.Transient;
                if (this.StateChanged != null) {
                    PingPerformerEventArgs e = new PingPerformerEventArgs(this.state, "state changed");
                    this.StateChanged.BeginInvoke(this, e, null, null);
                }
            }
            else if (this.distanceToLastFail >= this.stabilityCount && this.state != State.Success) {
                // If the distance is greater or equal to watchedRepliesCount then our state should be Success.
                // If it's not, change it and raise an event.
                this.state = State.Success;
                if (this.StateChanged != null) {
                    PingPerformerEventArgs e = new PingPerformerEventArgs(this.state, "state changed");
                    this.StateChanged.BeginInvoke(this, e, null, null);
                }
            }
        }

        private void Failed()
        {
            this.distanceToLastFail = 0;

            // Increase number of failed pings
            this.failedPingsCount++;

            if (this.state != State.Failure) {
                this.state = State.Failure;
                if (this.StateChanged != null) {
                    PingPerformerEventArgs e = new PingPerformerEventArgs(this.state, "state changed");
                    this.StateChanged.BeginInvoke(this, e, null, null);
                }
            }
        }

        private void WriteMsgToLog(string message)
        {
            this.sequentNumber++;
            message = this.sequentNumber + ")  " + System.DateTime.Now.ToString() + "  " + message;

            if (this.ReplyRecieved != null) {
                PingPerformerEventArgs e = new PingPerformerEventArgs(this.state, message);
                this.ReplyRecieved.BeginInvoke(this, e, null, null);
            }
        }

        private void WriteMsgToLog(PingReply reply)
        {
            string msg;

            if (reply.Status == IPStatus.Success)
            {
                msg = string.Format("Reply from: {0}:  bytes = {1}  time = {2}ms  TTL= {3}", 
                    reply.Address.ToString(), reply.Buffer.Length, reply.RoundtripTime, reply.Options.Ttl);
            }
            else
            {
                msg = reply.Status.ToString();
            }

            this.WriteMsgToLog(msg);                        
        }

        private void RunThread()
        {
            Ping pinger = new Ping();
            PingOptions options = new PingOptions();
            PingReply reply;
            
            while (this.run)
            {
                try
                {
                    // Prepare ping options
                    options.Ttl = this.timeToLive;
                    options.DontFragment = this.dontFragment;

                    reply = pinger.Send(this.destinationAddress, this.timeoutDelay, this.buffer, options);

                    if (reply.Status == IPStatus.Success)
                        this.Successed();
                    else
                        this.Failed();

                    this.WriteMsgToLog(reply);
                }
                catch (PingException)
                {
                    this.Failed();
                    this.WriteMsgToLog("Ping request could not find " + this.destinationAddress +
                        ". Please check the name.");
                }
                catch (Exception)
                {
                    this.Failed();
                    this.WriteMsgToLog("Ping request could not find " + this.destinationAddress +
                        ". Please check the name.");
                }

                // Sleep
                if (this.pingInterval > 0)
                    System.Threading.Thread.Sleep(this.pingInterval);
            }            
        }
        
     
   
        #region Properties
        public string DestinationName
        {
            get { return this.destinationName; }
            set { this.destinationName = value; }
        }

        public string DestinationAddress
        {
            get { return this.destinationAddress; }
            set { this.destinationAddress = value; }
        }

        public State PingState
        {
            get { return this.state; }
        }

        public bool Stopped
        {
            get { return this.stopped; }
        }

        public bool IsStopping
        {
            get { return this.isStopping; }
        }


        public ulong SuccessfullPingsCount
        {
            get { return this.successfullPingsCount; }
        }

        public ulong FaildPingsCount
        {
            get { return this.failedPingsCount; }
        }

        public ulong TotalPingsCount
        {
            get { return this.successfullPingsCount + this.failedPingsCount; }
        }
        #endregion
    }
}

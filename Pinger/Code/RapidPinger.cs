using System;
using System.Threading;
using System.Net.NetworkInformation;
using System.Collections.Generic;

namespace PingTester
{
    public class RapidPingerEventArgs : EventArgs
    {
        public int TotalSuccess { get; private set;}
        public int TotalFail { get; private set; }

        public RapidPingerEventArgs(int success, int fail)
        {
            this.TotalSuccess = success;
            this.TotalFail = fail;
        }
    }

    public delegate void RapidPingerReplyRecievedHandler(RapidPinger sender, RapidPingerEventArgs e);

    public class RapidPinger
    {
        private object _locker = new object();
        private int _totalSuccess;
        private int _totalFail;
        private int _totalUnknown;
        private Timer _stopTimer;

        public event RapidPingerReplyRecievedHandler ReplyRecieved;

        public PingPerformer[] Pingers { get; private set; }
        public TimeSpan Duration { get; private set; }
        public int UsersCount { get; private set; }
        public int AggregationCount { get; private set; }


        public RapidPinger(string host, int usersCount, TimeSpan duration, int aggregationCount)
        {
            this.AggregationCount = aggregationCount;
            this.Duration = duration;
            this.UsersCount = usersCount;
            this.Pingers = new PingPerformer[this.UsersCount];
            for (int i = 0; i < this.Pingers.Length; i++) {
                var pinger = new PingPerformer("", host, 0, 10, 32, true, 2000, 0);
                pinger.ReplyRecieved += pinger_ReplyRecieved;
                this.Pingers[i] = pinger;
            }
        }

        public void Start()
        {
            foreach (var pinger in this.Pingers)
                pinger.Start();

            this._stopTimer = new Timer(stopTimer_Elapsed, null, this.Duration, TimeSpan.FromMilliseconds(-1));
        }


        private void stopTimer_Elapsed(object state)
        {
            foreach (var pinger in this.Pingers)
                pinger.Stop();

            if (this.ReplyRecieved != null) {
                var newEvent = new RapidPingerEventArgs(_totalSuccess, _totalFail);
                this.ReplyRecieved.BeginInvoke(this, newEvent, null, null);
            }
        }

        private void pinger_ReplyRecieved(PingPerformer sender, PingPerformerEventArgs e)
        {
            if (this.ReplyRecieved == null)
                return;

            lock (_locker) {
                if (e.State == State.Failure)
                    _totalFail++;
                else if (e.State == State.Success || e.State == State.Transient)
                    _totalSuccess++;
                else
                    _totalUnknown++;

                if (AggragationCountReached()) {
                    var newEvent = new RapidPingerEventArgs(_totalSuccess, _totalFail);
                    this.ReplyRecieved.BeginInvoke(this, newEvent, null, null);
                }
            }
        }

        private bool AggragationCountReached()
        {
            var ret = (_totalFail + _totalSuccess + _totalUnknown) % this.AggregationCount == 0;
            return ret;
        }
    }
}

using System;
using System.Threading;
using System.Net.NetworkInformation;

namespace PingTester
{
    public class RapidPingerEventArgs : EventArgs
    {
        public bool Success { get; private set;}
    }

    public class RapidPinger
    {
        public event ReplyRecievedHandler ReplyRecieved;     
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNet.Stomp.Client.Utils
{
    public static class StompCommand
    {
        //Client Command
        public const string Connect = "CONNECT";
        public const string Disconnect = "DISCONNECT";
        public const string Subscribe = "SUBSCRIBE";
        public const string Unsubscribe = "UNSUBSCRIBE";
        public const string Send = "SEND";

        //Server Response
        public const string Connected = "CONNECTED";
        public const string Message = "MESSAGE";
        public const string Error = "ERROR";
    }
}

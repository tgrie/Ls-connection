﻿namespace RayanCnc.LSConnection.Events
{
    public class OnReadedSuccessfullyEventArgs : ILsEventArgs
    {
        public object Packet { get; set; }
        public object Request { get; set; }
    }
}

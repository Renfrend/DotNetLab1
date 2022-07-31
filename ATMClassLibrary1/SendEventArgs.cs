using System;

namespace ATMClassLibrary
{
    public class SendEventArgs :EventArgs
    {
        public bool Result { get; private set; }
        public SendEventArgs(bool result)
        {
            Result = result;
        }
    }
}

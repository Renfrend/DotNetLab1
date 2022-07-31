using System;

namespace ATMClassLibrary
{
    public class AuthEventArgs : EventArgs
    {
        public string Result { get; private set; }
        
        public AuthEventArgs(string result)
        {
            Result = result;           
        }
    }
}

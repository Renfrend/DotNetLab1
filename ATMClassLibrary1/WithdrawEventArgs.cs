using System;

namespace ATMClassLibrary
{
    public class WithdrawEventArgs : EventArgs
    {
        public bool Result { get; private set; }
        public int Sum { get; private set; }
        public WithdrawEventArgs(bool result,int sum)
        {
            Result = result;
            Sum = sum;
        }
    }
}

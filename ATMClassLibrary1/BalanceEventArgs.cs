using System;

namespace ATMClassLibrary
{
    public class BalanceEventArgs :EventArgs
    {
        public int Balance { get; private set; }
        
        public BalanceEventArgs(int balance) 
        { 
            Balance = balance;
        }
    }
}

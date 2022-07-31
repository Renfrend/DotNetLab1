using System;

namespace ATMClassLibrary
{
    public class Cards
    {
     
        public int Number { get; private set; }
        public int Pincode { get; private set; }

        public Cards(int number, int pincode)
        {
            Number = number;
            Pincode = pincode;
        }
        public override string ToString() 
        {
            return $"{Number} {Pincode}";
        }
    }
}

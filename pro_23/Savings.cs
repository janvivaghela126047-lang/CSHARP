using System;

namespace pro_23
{
    public  class Savings : Account
    {
        public double interestRate = 5.0;

        public override void Withdraw(double ammount)
        {
            if (ammount <= balance)
            {
                balance -= ammount;
                Console.WriteLine("Withdraw from current: " + ammount);
            }
            else
            {
                Console.WriteLine("Overdraft Limit exceeded");
            }
        }
    }
}

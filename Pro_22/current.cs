using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_22
{
    internal class current:account
    {
        public double overdraftLimit = 1000;
        public override void Withdraw(double amount)
        {
            if (amount <= balance + overdraftLimit)
            {
                balance += amount;
                Console.WriteLine("Withdraw from current :" + amount);
            }
            else
            {
                Console.WriteLine("overdraft limit exceeded");

            }
        }
    }
}

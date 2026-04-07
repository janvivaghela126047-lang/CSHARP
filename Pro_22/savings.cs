using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_22
{
    internal class savings:account
    {
        public double intrestRate = 5.0;
        public override void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance = amount;
                Console.WriteLine("Withdrawn from saving:" + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");  
            }
        }
    }
}

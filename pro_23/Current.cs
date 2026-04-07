using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_23
{
    public class Current : Account
    {
        public double OverdraftLimit = 1000;
        
        public override void Withdraw(double ammount)
        {
            if (ammount <= balance + OverdraftLimit)
            { 
                balance -= ammount;
                Console.WriteLine("Withdrawn from current:" + ammount);
            }
            else
            {
                Console.WriteLine("Overdraft limit exceeded");
            }
        }
    }
}

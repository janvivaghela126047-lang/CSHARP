using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Saving account----");
            savings s = new savings();
            s.GetAccountData();
            s.Deposit(500);
            s.Withdraw(300);
            s.CheckBalance();

            Console.WriteLine("\n----current account----");
            current c = new current();
            c.GetAccountData();
            c.Deposit(1000);
            c.Withdraw(1500);
            c.CheckBalance();

            Console.ReadLine();
        }
    }
}

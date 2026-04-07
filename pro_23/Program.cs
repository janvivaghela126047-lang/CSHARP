using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----saving account----");
            Savings s = new Savings();
            s.GetAccountData();
            s.Deposit(500);
            s.Withdraw(300);
            s.CheckBalance();

            Console.WriteLine("\n----current account----");
            Current c = new Current();
            c.GetAccountData();
            c.Deposit(1000);
            c.Withdraw(1500);
            c.CheckBalance();

            Console.ReadLine();

        }
    }
}

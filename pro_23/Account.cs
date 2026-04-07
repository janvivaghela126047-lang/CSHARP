using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_23
{
    public abstract class Account
    {
        public int accountno;
        public double balance;

        public void GetAccountData()
        {
            Console.Write("enter account no: ");
            accountno = Convert.ToInt16(Console.ReadLine());

            Console.Write("enter balance:");
            balance = Convert.ToDouble(Console.ReadLine());
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("deposited:" + amount);
        }

        public abstract void Withdraw(double amount);

        public void CheckBalance()
        {
            Console.WriteLine("balance:" + balance);
        }
    }
}

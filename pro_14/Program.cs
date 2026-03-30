using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            int n = int.Parse(Console.ReadLine());
            int m, rev = 0;
            int temp = n;
            while (n > 0)
            {
                m = n % 10;
                rev = rev * 10 + m;
                n = n / 10;
            }
            if (rev == temp)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrom");
            }
        }
    }
}

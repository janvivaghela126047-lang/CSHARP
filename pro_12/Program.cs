using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int n = int.Parse(Console.ReadLine());

            int m;
            int sum = 0;
            while (n > 0)
            {
                m = n % 10;
                n = n/ 10;
                sum += m;
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}

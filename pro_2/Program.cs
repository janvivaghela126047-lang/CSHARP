using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("addition");
            Console.WriteLine("enter value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a / b;
            int f = a * b;
            Console.WriteLine("ans: a + b = " + c);
            Console.WriteLine("ans: a - b = " + d);
            Console.WriteLine("ans: a / b = " + e);
            Console.WriteLine("ans: a * b = " + f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("number is even ");
            else
                Console.WriteLine("number is odd ");
        }
    }
}

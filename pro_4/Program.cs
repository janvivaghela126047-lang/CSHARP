using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("compound Intrest");
            Console.WriteLine("Enter value of pricipal");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for rate of Intrest");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for year");
            float n = float.Parse(Console.ReadLine());
            double amount = p * Math.Pow(1 + r / 100 , n);
            double Compoundintrest = amount - p;
            Console.WriteLine("compond Intrest: "+ Compoundintrest);
        }
    }
}

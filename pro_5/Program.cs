using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of the circle");
            double r = double.Parse(Console.ReadLine());
            double a = 3.14 * r * r;
            Console.WriteLine("area of the circle: " + a );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape t = new Triangle(5, 10);
            Shape r = new Rectangle(4, 6);
            Shape c = new Circle(3);

            Console.WriteLine("Triangle Area = " + t.Area());
            Console.WriteLine("Rectangle Area = " + r.Area());
            Console.WriteLine("Circle Area = " + c.Area());
        }
    }
}

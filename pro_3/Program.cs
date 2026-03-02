using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simpal Intrest");
            Console.WriteLine("enter value for principal");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("enter value for rate intrest");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("enter value for year");
            float t = float.Parse(Console.ReadLine());
            float s =(p * r * t) / 100;
            Console.WriteLine("intrest: " + s);
        }
    }
}

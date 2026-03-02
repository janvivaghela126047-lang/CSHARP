using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter age: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 13)
                Console.Write("you are kid ");
            else if (n < 17)
                Console.Write("you are teenager ");
            if (n < 60)
                Console.Write("you are adual ");
            else
                Console.Write("you are senior citizen ");
        }
    }
}

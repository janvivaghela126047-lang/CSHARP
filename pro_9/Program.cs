using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ente number: ");
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3 = 1;
            Console.Write(n1 + " ");
            Console.Write(n2 + " ");
            while (n3 <= n)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("eneter number :");
            int n = int.Parse(Console.ReadLine());
            int i, m;
            int flag = 0;
            for (i = 2; i < n - 1; i++)
            {
                m = n % 1;
                if(m==0)
                {
                    Console.WriteLine("not prime number ");
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("prime number ");
            }

        }
    }
}

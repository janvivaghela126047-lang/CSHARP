using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int max;

            Console.WriteLine("enter 5 number: ");
            for (int i = 1; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            max = a[0];
            for (int i = 1; i < 5; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("maximum number is : " + max);
        }
    }
}

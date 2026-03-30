using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, temp, remainder;
            Console.WriteLine("Enter a number :");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (temp != 0)
            {
                remainder = temp % 10;
                sum += remainder * remainder * remainder;
                temp /= 10;

            }
            if (sum == num)
            {
                Console.WriteLine(num + "is an armstrong number ");
            }
            else
            {
                Console.WriteLine(num + "is not armstrong number ");
            }
        }
    }
}

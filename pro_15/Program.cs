using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            String revname = "";
            int i;
            for (i = name.Length - 1; i >= 0; i--)
            {
              revname += name[i];

            }
            if (name == revname)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.calculate();
            r1.display();
            Rectangle r2 = new Rectangle(30 , 40);
            r2.calculate();
            r2.display();
        }
    }
}

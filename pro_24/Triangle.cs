using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_24
{
    internal class Triangle:Shape
    {
        private double basevalue;
        private double height;

        public Triangle(double b, double h)
        {
            basevalue = b;
            height = h;
        }

        public override double Area()
        {
            return basevalue * height;
        }
    }
}

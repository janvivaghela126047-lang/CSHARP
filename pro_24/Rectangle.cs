using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_24
{
    internal class Rectangle:Shape
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override double Area()
        {
            return length * length;
        }
    }
}

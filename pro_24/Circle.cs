using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_24
{
    internal class Circle: Shape
    {
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}

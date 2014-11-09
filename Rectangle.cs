using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Rectangle : Shape
    {
            public override double Area
        {
            get { return (Lenght) * (Width); }
        }

        public override double Perimeter
        {
            get { return (2 * Lenght) * (2 * Width);}
        }
        public Rectangle(double length, double width): base(length, width)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Ellipse : Shape
    {
        public override double Area
        {
            get { return (Lenght / 2) * (Width / 2) * (Math.PI); }
        }

        public override double Perimeter
        {
            get { return  Math.PI * Math.Sqrt( 2 * (Lenght/2) * (Lenght/2) + 2 * (Width/2) *(Width/2));  }
        }
        public Ellipse(double length, double width): base(length, width)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    abstract class Shape
    {
        private double _width;
        private double _length;

        public abstract double Area //Hämtar ett värde Ellipse eller Rectangle.
        {
            get;
        }
        public double Lenght
        {
            get { return _length; }

            set
            {
                if (value < 0) //kollar så att värdet på _lenght är större än 0.
                {
                    throw new ArgumentException(); // Är värdet mindre än noll så kanstas här ett undantag
                }
                _length = value; //Annars sätts _lenght värdet till Value
            }
        }

        public abstract double Perimeter  //Hämtar ett värde Ellipse eller Rectangle.
        {
            get;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0) //kollar så att värdet på _width är större än 0.
                {
                    throw new ArgumentException(); // Är värdet mindre än noll så kanstas här ett undantag
                }
                _width = value; //Annars sätts _lenght värdet till Value
            }
        }
        protected Shape(double lenght, double width) // Ger Lenght och width samma värden som length width.
        {
            Lenght = lenght;
            Width = width;

        }
        public override string ToString()
        {
            return String.Format("Length      : {0,10:f2}\nWidth       : {1, 10:f2}\nPerimeter   : {2, 10:f2}\nArea        : {3, 10:f2}", Lenght, Width, Perimeter, Area);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_03
{
    class Rectangle : Shape
    {

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
       public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}

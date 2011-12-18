using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_03
{
    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            Height = height;
            Width = width;
        }



       public override double CalculateSurface()
        {
            return (Height * Width)/2;
        }

    }
}

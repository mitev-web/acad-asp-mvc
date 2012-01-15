using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_03
{
    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius)
        {
            Radius = radius;
            Width = 2 * radius;
            Height = 2 * radius;

        }


        public override double CalculateSurface()
        {
            //S = π.r2
            return Math.PI * (Math.Pow(Radius, 2));
        }
    }
}

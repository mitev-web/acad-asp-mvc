using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_03
{
    abstract class Shape
    {

        private double width;

        public double Width
        {
          get { return width; }
          set { width = value; }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public abstract double CalculateSurface();

    
    }
}

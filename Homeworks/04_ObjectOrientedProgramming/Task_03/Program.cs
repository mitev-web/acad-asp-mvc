using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
            //Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
            //(height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor, so that on 
            //initialization height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests
            //the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.

            Circle c = new Circle(4.5);
            Rectangle r = new Rectangle(4, 7);
            Triangle t = new Triangle(3, 5);

            List<Shape> shapes = new List<Shape> { c, r, t };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine("the surface of the {0} is {1:F2}", shape.GetType(),shape.CalculateSurface());
            }

            
        }
    }
}

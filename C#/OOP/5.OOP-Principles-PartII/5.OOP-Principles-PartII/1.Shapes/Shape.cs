/*1.Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
  Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
  (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor 
  so that at initialization height must be kept equal to width and implement the CalculateSurface() method. 
  Write a program that tests the behavior of  the CalculateSurface() method for different shapes 
  (Circle, Rectangle, Triangle) stored in an array.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width;
        protected double height;

        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive.");
                }
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }
                height = value;
            }
        }

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}

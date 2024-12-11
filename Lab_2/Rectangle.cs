using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rectangle
    {
        public double Length;
        public double Width;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public void DisplayArea()
        {
            double area = Length * Width;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }
}

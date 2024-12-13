using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Area3
    {
        public void area(int length)
        {
            Console.WriteLine("Area of Square = " + length * length);
        }
        public void area(int length,int width)
        {
            Console.WriteLine("Area of Rectangle = " + length * width);
        }
        public void area(float radius)
        {
            Console.WriteLine("Area of Circle = "+Math.PI*radius*radius);
        }
    }
    internal class Lab_4_5
    {
        public void run()
        {
            Area3 a = new Area3();
            Console.Write("Enter length of Square : ");
            int l = int.Parse(Console.ReadLine());
            a.area(l);
            Console.Write("Enter length of rectangle : ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle ; ");
            int width = int.Parse(Console.ReadLine());
            a.area(length, width);
            Console.Write("Enter radius of circle : ");
            float radius = float.Parse(Console.ReadLine());
            a.area(radius);

        }
    }
}

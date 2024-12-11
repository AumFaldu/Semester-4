using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface Shape
    {
        void Circle();
        void Triangle();
        void Square();
    }
    class Area : Shape
    {
        public void Circle()
        {
            Console.Write("Enter radius : ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Circle = " + Math.PI * radius * radius);
        }
        public void Triangle()
        {
            Console.Write("Enter base : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter height : ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Triangle = " + b * h/2);
        }
        public void Square()
        {
            Console.Write("Enter length of side : ");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of Square  = " + side * side);
        }
    }
    internal class Lab_3_7
    {
        public void run()
        {
            Area area = new Area();
            area.Circle();
            area.Triangle();
            area.Square();
        }
    }
}

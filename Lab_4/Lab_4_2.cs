using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Area
    {
        public void area(int length)
        {
            Console.WriteLine("Area of Square = " + length * length);
        }
        public void area(int length,int width)
        {
            Console.WriteLine("Area of Rectangle = "+length*width);
        }
    }
    internal class Lab_4_2
    {
        public void run()
        {
            Area a = new Area();
            Console.Write("Enter length of square : ");
            int l = int.Parse(Console.ReadLine());
            a.area(l);
            Console.Write("Enter length of rectangle : ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle : ");
            int width = int.Parse(Console.ReadLine());
            a.area(length, width);
        }
    }
}

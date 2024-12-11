using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Furniture
    {
        public string Material;
        public double Price;

        public Furniture(string material, double price)
        {
            Material = material;
            Price = price;
        }
    }

    class Table : Furniture
    {
        public double Height;
        public double SurfaceArea;

        public Table(string material, double price, double height, double surfaceArea)
            : base(material, price)
        {
            Height = height;
            SurfaceArea = surfaceArea;
        }

        public void DisplayTableDetails()
        {
            Console.WriteLine($"Material: {Material}, Price: {Price}, Height: {Height}, Surface Area: {SurfaceArea}");
        }
    }
}

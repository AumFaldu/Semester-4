using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        public int ID;
        public string Name;
        public int Age;
        public float Weight;
        public float Height;

        public void GetCandidateDetails()
        {
            Console.Write("Enter ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Weight: ");
            Weight = float.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            Height = float.Parse(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine($"Candidate ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Height: {Height}");
        }
    }
}

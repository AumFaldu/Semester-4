using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string Name;
        public string Department;
        public string Designation;
        public int Experience;
        public double Salary;

        public void AcceptStaffDetails()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Name of Staff {i + 1}: ");
                Name = Console.ReadLine();
                Console.Write("Enter Department: ");
                Department = Console.ReadLine();
                Console.Write("Enter Designation: ");
                Designation = Console.ReadLine();
                Console.Write("Enter Experience (in years): ");
                Experience = int.Parse(Console.ReadLine());
                Console.Write("Enter Salary: ");
                Salary = double.Parse(Console.ReadLine());
            }
        }

        public void DisplayHODs()
        {
            Console.WriteLine("\nStaff HODs:");
            if (Designation == "HOD")
            {
                Console.WriteLine($"Name: {Name}, Salary: {Salary}");
            }
        }
    }
}

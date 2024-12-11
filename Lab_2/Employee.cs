using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface Gross
    {
        void Gross_sal();
    }

    class Sal : Gross
    {
        public double HRA;
        public double TA;
        public double DA;

        public Sal(double hra, double ta, double da)
        {
            HRA = hra;
            TA = ta;
            DA = da;
        }

        public void Gross_sal()
        {
            Console.WriteLine($"Gross Salary: {HRA + TA + DA}");
        }

        public void Disp_sal()
        {
            Console.WriteLine("Displaying Salary Details.");
        }
    }

    class Employee : Sal
    {
        public string Name;

        public Employee() : base(5000, 300, 200)
        { }

        public void basic_sal()
        {
            Console.WriteLine("Basic Salary");
        }
    }
}

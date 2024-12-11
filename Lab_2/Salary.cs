using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary(double basic, double ta, double da)
        {
            Basic = basic;
            TA = ta;
            DA = da;
            HRA = 0;
        }

        public void DisplaySalary()
        {
            double totalSalary = Basic + TA + DA + HRA;
            Console.WriteLine($"Total Salary: {totalSalary}");
        }
    }
}

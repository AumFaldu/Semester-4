using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        public double Dist1;
        public double Dist2;
        public double Dist3;

        public Distance(double dist1, double dist2)
        {
            Dist1 = dist1;
            Dist2 = dist2;
            Dist3 = 0;
        }

        public void AddDistances()
        {
            Dist3 = Dist1 + Dist2;
            Console.WriteLine($"Total Distance: {Dist3}");
        }
    }
}

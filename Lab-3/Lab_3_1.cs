using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_1
    {
        
        public void DivideByZero()
        {
            try
            {
                int dividend = 1;
                int divisor = 0;
                Console.WriteLine("Ans = " +dividend/divisor);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

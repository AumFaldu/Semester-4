using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_8
    {
        public void run()
        {
            try
            {
                Console.Write("Enter a number : ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    throw new Exception("Number is not Even");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

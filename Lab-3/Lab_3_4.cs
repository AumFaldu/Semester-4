using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface ICalculate
    {
        void Addition();
        void Subtraction();
    }
    class Result:ICalculate
    {
        public void Addition()
        {
            Console.Write("Enter value of a :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition = " + (a + b));
        }
        public void Subtraction()
        {
            Console.Write("Enter value of a :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Subtraction = " + (a - b));
        }
    }
    internal class Lab_3_4
    {
        public void run()
        {
            Result result = new Result();
            result.Addition();
            result.Subtraction();
        }
    }
}

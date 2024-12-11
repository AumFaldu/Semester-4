using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    abstract class Sum
    {
        public abstract void SumOfTwo();
        public abstract void SumOfThree();
    }
    internal class Calculate:Sum
    {
        public override void SumOfTwo()
        {
            Console.Write("Enter value of a :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Two = "+(a + b));
        }
        public override void SumOfThree()
        {
            Console.Write("Enter value of a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter value of c : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Three = " + (a + b + c));

        }
    }
    internal class Lab_3_3
    {
        public void run()
        {
            Calculate ca = new Calculate();
            ca.SumOfTwo();
            ca.SumOfThree();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    abstract class Sum
    {
        public void SumOfTwo(int a, int b);
        public void SumOfThree(int a, int b, int c);
    }
    internal class Calculate:Sum
    {
        public void SumOfTwo(int a,int b)
        {
            Console.Write("Enter value of a :");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b :");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Two = "+(a + b));
        }
        public void SumOfThree(int a,int b,int c)
        {
            Console.Write("Enter value of a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter value of c : ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Three = " + (a + b + c));

        }
    }
}

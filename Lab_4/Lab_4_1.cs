using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Add
    {
        public int addTwo(int a, int b)
        {
            return a + b;
        }
        public float addTwo(float a, float b)
        {
            return a + b;
        }
    }
        public class Lab_4_1
        {
            public void run()
            {
                Add a = new Add();
                Console.Write("Enter integer value of a : ");
                int ai = int.Parse(Console.ReadLine());
                Console.Write("Enter integer value of b : ");
                int bi = int.Parse(Console.ReadLine());
                Console.WriteLine("Addition = " + a.addTwo(ai, bi));
                Console.Write("Enter float value of a : ");
                float af = float.Parse(Console.ReadLine());
                Console.Write("Enter float value of b : ");
                float bf = float.Parse(Console.ReadLine());
                Console.WriteLine("Addition = " + a.addTwo(af, bf));
            }
        }
    }


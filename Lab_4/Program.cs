using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for Lab_4_1 : ");
            Console.WriteLine("Press 2 for Lab_4_2 : ");
            Console.WriteLine("Press 3 for Lab_4_3 : ");
            Console.WriteLine("Press 4 for Lab_4_4 : ");
            Console.WriteLine("Press 5 for Lab_4_5 : ");
            Console.WriteLine("Press 6 for Lab_4_6 : ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Lab_4_1 l1 = new Lab_4_1();
                    l1.run();
                    break;
                case 2:
                    Lab_4_2 l2 = new Lab_4_2();
                    l2.run(); 
                    break;
                case 3:
                    Lab_4_3 l3 = new Lab_4_3();
                    l3.run();
                    break;
                case 4:
                    Lab_4_4 l4 = new Lab_4_4();
                    l4.run();
                    break;
                case 5:
                    Lab_4_5 l5 = new Lab_4_5();
                    l5.run();
                    break;
                case 6:
                    Lab_4_6 l6 = new Lab_4_6();
                    l6.run();
                    break;
            }
        }
    }
}

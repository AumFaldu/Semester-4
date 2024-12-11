using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display menu options
            Console.WriteLine("Select a number to run the corresponding Lab method:");
            Console.WriteLine("1. Lab_3_1 (DivideByZero)");
            Console.WriteLine("2. Lab_3_2 (IndexOutOfRange)");
            Console.WriteLine("3. Lab_3_3");
            Console.WriteLine("4. Lab_3_4");
            Console.WriteLine("5. Lab_3_5");
            Console.WriteLine("6. Lab_3_6");
            Console.WriteLine("7. Lab_3_7");
            Console.WriteLine("8. Lab_3_8");
            Console.WriteLine("9. Lab_3_9");
            Console.WriteLine("10. Lab_3_10");
            Console.Write("Enter your choice (1-10): ");

            int choice = int.Parse(Console.ReadLine());

            // Use switch-case to run the corresponding method
            switch (choice)
            {
                case 1:
                    Lab_3_1 l1 = new Lab_3_1();
                    l1.DivideByZero();
                    break;

                case 2:
                    Lab_3_2 l2 = new Lab_3_2();
                    l2.IndexOutOfRange();
                    break;

                case 3:
                    Lab_3_3 l3 = new Lab_3_3();
                    l3.run();
                    break;

                case 4:
                    Lab_3_4 l4 = new Lab_3_4();
                    l4.run();
                    break;

                case 5:
                    Lab_3_5 l5 = new Lab_3_5();
                    l5.run();
                    break;

                case 6:
                    Lab_3_6 l6 = new Lab_3_6();
                    l6.run();
                    break;

                case 7:
                    Lab_3_7 l7 = new Lab_3_7();
                    l7.run();
                    break;

                case 8:
                    Lab_3_8 l8 = new Lab_3_8();
                    l8.run();
                    break;

                case 9:
                    Lab_3_9 l9 = new Lab_3_9();
                    l9.run();
                    break;

                case 10:
                    Lab_3_10 l10 = new Lab_3_10();
                    l10.run();
                    break;

                default:
                    Console.WriteLine("Invalid choice, please select a number between 1 and 10.");
                    break;
            }
        }
    }
}

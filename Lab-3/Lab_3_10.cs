using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_10
    {
        public void run()
        {
            Console.Write("Enter a character : ");
            char c = Console.ReadKey().KeyChar;
            if (char.IsLower(c))
            {
                Console.WriteLine($"\nThe character in uppercase: {char.ToUpper(c)}");
            }
            else if (char.IsUpper(c))
            {
                Console.WriteLine($"\nThe character in lowercase: {char.ToLower(c)}");
            }
            else
            {
                Console.WriteLine("\nEnter a valid character");
            }
        }
    }
}

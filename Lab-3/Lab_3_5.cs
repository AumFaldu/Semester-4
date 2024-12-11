using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_5
    {
        public void run()
        {
            String str1 = "Hello, World!";
            String str2 = "C# Programming";

            Console.WriteLine("Length of str1 : " + str1.Length);
            Console.WriteLine("Uppercase str1 : " + str1.ToUpper());
            Console.WriteLine("Lowercase str2 : " + str2.ToLower());
            Console.WriteLine("str1 contains 'World': "+str1.Contains("World"));
            Console.WriteLine("Index of 'World' in str1: " + str1.IndexOf("World"));
            Console.WriteLine("Substring of str1: "+str1.Substring(7,5));
            Console.WriteLine("Replace 'World' with 'C#' in str1: " + str1.Replace("World", "C#"));
        }
    }
}

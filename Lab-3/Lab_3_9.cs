using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_9
    {
        public void run()
        {
            Console.Write("Enter a sentence : ");
            String sentence = Console.ReadLine();
            String[] words = sentence.Split(' ');
            int max = 0;
            String ans = "";
            foreach(string s in words)
            {
                if (max < s.Length)
                {
                    max = s.Length;
                    ans = s;
                }
            }
            Console.WriteLine("Enter the Longest Word : " + ans);

        }
    }
}

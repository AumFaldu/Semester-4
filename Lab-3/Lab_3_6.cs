using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_6
    {
        public void run()
        {
            Console.Write("Enter a string : ");
            String s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                if (char.IsLower(ch[i]))
                {
                    ch[i] = char.ToUpper(ch[i]);
                }
                else if (char.IsUpper(ch[i]))
                {
                    ch[i] = char.ToLower(ch[i]);
                }
            }
            String result = new String(ch);
            Console.WriteLine("Converted String = " + result);

        }
    }
}

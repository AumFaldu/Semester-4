using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Lab_3_2
    {
        public void IndexOutOfRange()
        {
            try
            {
                int[] arr = new int[5];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Enter value of arr[" + i + "] : ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter index : ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(arr[index]);
            }
            catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex);
            }
        }
    }
}

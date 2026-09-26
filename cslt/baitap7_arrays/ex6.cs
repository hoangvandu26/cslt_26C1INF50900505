using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(1, 50);
            }

            Console.Write("Mảng: \t\t\t");
            foreach (int i in arr)
            { Console.Write(i + " "); }
            Console.WriteLine();

            int[] arr2 = new int[10];

            for(int i = 0,j= arr.Length - 1; i < arr.Length; i++,j--)
            {  
                arr2[i] = arr[j];
                
            }
            Console.Write("Mảng sau khi đảo ngược: ");
            foreach (int i in arr2)
            { Console.Write(i + " "); }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

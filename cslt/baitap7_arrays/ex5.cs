using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex5
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
            Console.Write("Mảng: ");
            foreach (int i in arr)
            { Console.Write(i + " "); }
            Console.WriteLine();
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }

            }
            Console.Write($"\nGiá trị lớn nhất trong mảng: {arr[9]}\n");
            Console.Write($"\nGiá trị nhỏ nhất trong mảng: {arr[0]}");
            Console.ReadKey();
        }
        
    }
}

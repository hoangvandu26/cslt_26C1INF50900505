using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex7
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random rnd = new Random();
            int[] arr = new int[15];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 20);
            }

            Console.Write("Mảng: ");
            foreach (int i in arr)
            { Console.Write(i + " "); }
            Console.WriteLine();

            Console.Write("Các phần tử trùng lặp trong mảng: ");
            for(int i = 0;i < arr.Length; i++)
            {
                for(int j = i+1;j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        Console.Write(arr[i]+" ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

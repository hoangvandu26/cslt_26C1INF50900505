using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex8
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
            int dem = 0;
            int a = arr.Length;
            for (int i = 0; i < a; i++)
            {
                for (int j = i + 1; j < a; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        for(int k = j;k < a-1; k++)  
                        { arr[k] = arr[k+1];
                            
                        }
                        a--;
                        j--;
                        dem ++; 
                    }
                }
            }

            int length = arr.Length - dem;
            int[] arr2 = new int[length];
            Console.Write("\nMảng sau khi xóa các phần tử trùng lặp: ");
            for (int i = 0; i < length; i++)
            {
                arr2[i] = arr[i];
            }
            foreach (int i in arr2)
            { Console.Write(i + " "); }
            Console.ReadKey();
        }
    }
}

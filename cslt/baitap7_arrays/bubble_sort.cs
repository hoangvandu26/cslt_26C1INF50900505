using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class bubble_sort
    {   /* Create a C# program that
- requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
        */
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arr = new int[10];
            Console.WriteLine("Nhập 10 phần tử cho mảng:");
             for(int i = 0; i <= 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if(i == 9) { break; }
            }
             for(int i =0;i < 10; i++)
            {
                for(int j = i+1;  j < 10; j++)
                {
                    if (arr[i] > arr[j])
                    { swap(arr, i, j); }
                }
            }

            Console.Write("Mảng sau khi sắp sếp: ");
            foreach (int i in arr)
            { Console.Write(i + " "); }
            Console.ReadKey();
        }
        static void swap(int[] arr,int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}

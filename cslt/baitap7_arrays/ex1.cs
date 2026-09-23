using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex1
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
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            sum /= arr.Length;

            Console.Write("Mảng: ");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine($"\nTrung bình cộng của các phần tử trong mảng: {sum}");
        }
    }
}

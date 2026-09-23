using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex3
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
            //
            Console.Write("Mảng: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            //
            Console.Write("\nNhập phần tử muốn tìm vị trí trong mảng: ");
            int so = int.Parse(Console.ReadLine());
            int vitri = -1;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == so) { vitri = i; ; break; }
            }
            Console.WriteLine($"Phần tử: {so} --> index {vitri}");
        }
        }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex2
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

            Console.Write("Nhập số để kiểm tra có trong mảng hay không: ");
            int tim = int.Parse(Console.ReadLine());

            bool kq = false;
            for (int i = 0; i < 10; i++)
            {
               if( arr[i] == tim) { kq = true;break; }
            }
            Console.WriteLine("\n"+kq);
            Console.Write("Mảng: ");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai10
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập các số để tính trung bình (cách nhau bởi dấu cách): ");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Kết quả: "+average(arr));
                
        }
        static double average(int[] a)
        {
            double avr = 0;
            for (int i = 0; i < a.Length; i++)
            {
                avr = avr + a[i];
            }
            avr = avr / a.Length;
            return avr;
        }
    }
}

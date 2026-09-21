using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai09
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập cơ số: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Lũy thừa của {a} cơ số {b} là: {luy_thua(a,b)}");
        }
        static double luy_thua(double x,int y)
        {
            double n = x;
            for (int i = 1; i < y; i++)
            {
                 n = n * x;
            }
            return n;
        }
    }
}

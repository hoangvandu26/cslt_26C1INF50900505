using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai03
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ba số để tìm số lớn nhất trong ba số:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Số lớn nhất trong ba số là: {MAX(a,b,c)}");

        }

        static int MAX(int a,int b,int c)
        {
            return Math.Max(Math.Max(a,b),c);
        }
    }
}

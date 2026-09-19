using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai04
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số muốn tính giai thừa : ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giá trị của !{x} = {giai_thua(x)}");

        }
        static long giai_thua(int a)
        {   int b = 1;
            for (int i = 1; i <= a; i++) { b *= i; }
            return b;
        }
    }
}

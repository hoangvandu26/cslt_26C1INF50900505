using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai02
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số để kiểm tra là chắn hay lẻ(true nếu chắn, false nếu là số lẻ) : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(check(n));

        }
        static bool check(int a)
        {
            return a % 2 == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai06
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên để kiểm tra có phải số nguyên tố hay không: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(KiemTraNguyenTo(n));
            
        }

        static bool KiemTraNguyenTo(int x)
        {
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
                return true;
        }
    }
}

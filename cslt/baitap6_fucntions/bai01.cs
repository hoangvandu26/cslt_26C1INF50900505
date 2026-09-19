using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai01
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập vào hai số để cộng:");
            int a= int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine($"Tổng của {a} và {b} : {add(a,b)} ");

        }

        static int add(int x, int y) {
            return x + y;
        }
    }
}

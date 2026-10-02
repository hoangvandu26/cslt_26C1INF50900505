using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session03
{
    internal class ex03
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập hai số nguyên để tính:");
            Console.Write("Nhập số thứ nhất: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a-b}");
            Console.WriteLine($"{a} * {b} = {a*b}");
            Console.WriteLine($"{a} / {b} = {a/b}");
        }
    }
}

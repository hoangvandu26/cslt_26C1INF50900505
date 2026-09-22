using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.Session02
{
    internal class ex2
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 9;
            Console.WriteLine($"truoc khi doi: a = {a}, b = {b} ");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"sau khi doi: a = {a}, b = {b}");
        }
    }
}

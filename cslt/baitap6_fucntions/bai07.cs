using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai07
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Bạn muốn biết bao nhiêu số đầu tiên trong dãy số Fibonacci: ");
            int a =int.Parse(Console.ReadLine());
            Console.Write("\n"+a+" số đầu tiên trong dãy số Fibonacci: ");
            Fibonacci(a);
            Console.ReadLine();
        }

        static void Fibonacci(int n)
        {
            
            for (int i = 0,j = 1; i <= n;) {
                
                Console.Write(i+" ");
                int x = i + j;
                i = j;
                j = x;
                
            }


        }
    }
}

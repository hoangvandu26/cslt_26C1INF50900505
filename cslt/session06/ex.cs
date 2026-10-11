using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session06
{
    internal class ex
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
           // ex01();
           // ex02();
           // ex03();

        }
        static void ex01()//1. Write a C# function to find the maximum of three numbers.
        {
            int[] a = new int[3];
            Console.Write("Nhập vào ba số (cách nhau bởi dấu cách): ");
            a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max=0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > max) { max = a[i]; }
            }
            Console.WriteLine($"Số lớn nhất trong ba số là: {max}");
        }

        static void ex02()//2. Write a C# function to calculate the factorial of a number (a non-negative
        {
                Console.Write("Nhập số cần tính giai thừa: ");
                int a = int.Parse(Console.ReadLine());
                int kq = 1;
                for (int i = 1; i <= a; i++)
                {
                    kq *= i;
                }
                Console.WriteLine($"{a}! = {kq}");
        }

        static void ex03()//4. Write a C# function to print
                          //1. all prime numbers that less than a number(enter prompt keyboard).
                          //2. the first N prime numbers
        { 
            Console.WriteLine("Lựa chọn: \n1 : In ra tất cả sô nguyên tố nhỏ hơn n.\n2 : In ra n số nguyên tố đầu tiên.");
            int luachon = int.Parse(Console.ReadLine());
            Console.Write("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            if(luachon == 1) { ex03_1(n); }
            else if(luachon==2) { ex03_2(n); }
            else { Console.WriteLine("Something went wrong!"); }

        


            static void ex03_1(int n)
            {
                Console.Write($"Tất cả số nguyên tố nhỏ hơn {n}: ");
                if (n > 2) { Console.Write("2 "); }
                for (int j = 3; j < n; j += 2)
                {
                    bool check = true;

                    for (int i = 3; i * i <= j; i += 2)
                    {
                        if (j % i == 0) { check = false; break; }
                    }
                    if (check) { Console.Write(j + " "); }
                }
            }

            static void ex03_2(int n)
            {
                Console.WriteLine($"{n} Số nguyên tố đầu tiên: ");
                int x = 0;
                Console.Write("2 ");
                for (int j = 3; x < n; j += 2)
                {
                    bool check = true;

                    for (int i = 3; i * i <= j; i += 2)
                    {
                        if (j % i == 0) { check = false; break; }
                    }
                    if (check) { Console.Write(j + " "); }
                    x++;
                }
            }

        }

    }
}

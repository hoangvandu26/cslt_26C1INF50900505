using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session04
{
    internal class ex
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //ex01();
            //ex03();
            //ex05();

            
        }

        static void ex05()
        {
            Console.Write("Nhập một ký tự để kiểm tra có phải nguyên âm không: ");
            char x = Console.ReadLine()[0];

            if(x == 'a'||x == 'i'||x == 'i'||x == 'o'||x == 'u')
            {
                Console.WriteLine("Bạn vừa nhập một nguyên âm!");
            }
            else { Console.WriteLine("Không phải nguyên âm"); }

        }

        static void ex03()
        {
            Console.Write("Nhập khoảng cách(km): ");
            int kc = int.Parse(Console.ReadLine());
            Console.Write("Nhập thời gian (h): ");
            int tg = int.Parse(Console.ReadLine());
            double kq1 = kc / tg ;
            double kq2 = kc / tg * 0.621371;
            Console.WriteLine(@$"Tốc độ tính theo km\h : {kq1} km\h");
            Console.WriteLine(@$"Tốc độ tính theo dặm\h : {kq2:f2} dặm\h");
        }

        static void ex01()
        {   
            Console.Write("Nhập số đầu tiên: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập phép tính: ");
            char i = char.Parse(Console.ReadLine());

            switch (i)
            {
                case '+': Console.WriteLine($"{a} + {b} = {a + b}");break;
                case '-': Console.WriteLine($"{a} - {b} = {a - b}");break;
                case '*': Console.WriteLine($"{a} * {b} = {a * b}");break;
                case '/': Console.WriteLine($"{a} / {b} = {a / b}");break;
                default: Console.WriteLine("Lỗi không thể xác định phép tính");break;
            }

        }
    }
}

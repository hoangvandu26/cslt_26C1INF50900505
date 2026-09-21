using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace baitp
{
    class Program
    {
        static void bai06()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số n:");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            Console.Write("số hạng của chuỗi điều hòa: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n) { Console.Write(" + "); }
                sum += 1.0 / i;
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Tổng của dãy số: {sum:F3}");
        }
        static void bai07()
        {
            static bool pfnum(int num)
            {
                if (num <= 1) return false;
                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                        sum += i;
                }
                return sum == num;
            }
            Console.OutputEncoding = Encoding.UTF8;

            int duoi;
            int tren;
            bool hople1;
            bool hople2;
            do { Console.Write("Nhập giới hạn dưới:");
               hople1= int.TryParse(Console.ReadLine(),out duoi) && duoi>=1;
                if (!hople1) { Console.WriteLine("Giới hạn dưới phải là số nguyên dương!"); }
               }while (!hople1);
            do
                { Console.Write("Nhập giới hạn trên:");
                hople2 = int.TryParse(Console.ReadLine(), out tren) && tren > duoi;
                if (!hople2) { Console.WriteLine("Giới hạn trên phải lớn hơn giới hạn dưới!"); }
                } while (!hople2);

            bool find = false;
            Console.WriteLine($"Các số hoàn hảo từ {duoi} đến {tren} là: ");
            for(int i = duoi;i<=tren;i++)
            {
               if(pfnum(i)) { Console.Write(i + " "); find = true; }
            }
            if (!find) { Console.WriteLine("Không tìm thấy số hoàn hảo trong khoảng tìm kiếm!"); }
            
        }
            static void Main()
            {
               // bai06();
               // bai07();

            }
        
    }
}

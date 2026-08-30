using System;
using System.Text;
namespace bai3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số tiền VNĐ: ");
            decimal soTienVND = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Chọn ngoại tệ:");
            Console.WriteLine("1 - USD");
            Console.WriteLine("2 - EUR");
            Console.WriteLine("3 - JPY");
            Console.WriteLine("4 - GBP");
            Console.Write("Lựa chọn (1-4): ");
            int chon = int.Parse(Console.ReadLine());

            decimal phi = soTienVND * 0.005m;
            decimal tienThuc = soTienVND - phi;

            decimal tyGia = 0;
            string tenTien = "";

            if (chon == 1)
            {
                tyGia = 25400;
                tenTien = "USD";
            }
            else if (chon == 2)
            {
                tyGia = 27200;
                tenTien = "EUR";
            }
            else if (chon == 3)
            {
                tyGia = 165;
                tenTien = "JPY";
            }
            else if (chon == 4)
            {
                tyGia = 32100;
                tenTien = "GBP";
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ!");
                return;
            }

            decimal soTienNgoai = tienThuc / tyGia;

            Console.WriteLine();
            Console.WriteLine("Phí dịch vụ (0.5%): " + phi.ToString("N0") + " VNĐ");
            Console.WriteLine("Số tiền VNĐ tính đổi: " + tienThuc.ToString("N0") + " VNĐ");
            Console.WriteLine("Số tiền " + tenTien + " nhận được: " + soTienNgoai.ToString("F2") + " " + tenTien);
        }
    }
}
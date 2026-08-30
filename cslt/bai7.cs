using System;
using System.Text;

namespace bai7
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập khoảng cách chuyến đi(km):");
            double khoangcach= double.Parse(Console.ReadLine());
            Console.Write("Nhập mức tiêu thụ nhiên liệu trung bình của xe(L/100km):");
            double tieuthu = double.Parse(Console.ReadLine());
            Console.Write("Nhập giá xăng hiện tại (VNĐ/Lít):");
            decimal giaxang= decimal.Parse(Console.ReadLine());
            Console.Write("Nhập số người tham gia chuyến đi:");
            int so_nguoi= int.Parse(Console.ReadLine());

            double tongL= (khoangcach/100)*tieuthu;
            decimal chiphixang = (decimal)tongL * giaxang;
            decimal tien = chiphixang / so_nguoi;

            Console.WriteLine($"Tổng nhiên liệu tiêu thụ:{tongL.ToString("F2")} lít");
            Console.WriteLine($"Tổng chi phí xăng dầu:{Math.Round(chiphixang).ToString("N0")} VND");
            Console.WriteLine("Chi phí mỗi người:"+ Math.Ceiling(tien).ToString("N0") +"VND");
            Console.ReadKey();




        }
    }
}

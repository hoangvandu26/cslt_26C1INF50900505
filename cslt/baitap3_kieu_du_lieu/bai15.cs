using System;
using System.Text;

namespace cslt.baitap3_kieu_du_lieu
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Loại khách hàng:");
            Console.WriteLine("1 - Trẻ em (Child)");
            Console.WriteLine("2 - Sinh viên (Student)");
            Console.WriteLine("3 - Người lớn (Adult)");
            Console.WriteLine("4 - Người cao tuổi (Senior)");
            Console.Write("Bạn thuộc khách hàng (chọn 1-4)?:");
            int loai = int.Parse(Console.ReadLine());

            Console.WriteLine("Chọn ngày đi xem phim(1-7) :");
            Console.WriteLine("1- Chủ nhât| 2- Thứ hai|3- Thứ ba|4- Thứ tư|5- Thứ năm|6- Thứ sáu|7- Thứ bảy");
            int ngay = int.Parse(Console.ReadLine());

            decimal giagoc = 100000;
            decimal giamgia = 0;
            decimal khuyenmai = 0;
            decimal phuthu = 0;

            if (ngay == 6 || ngay == 7 || ngay == 1) { phuthu = 20000; } else { phuthu = 0; }

            if (loai == 1 || loai == 4)
            {
                giamgia = giagoc * 0.5m;
                khuyenmai = 0;

            } else if (loai == 2 && (ngay == 2 || ngay == 3 || ngay == 4 || ngay == 5))
            {
                giamgia = giagoc * 0.3m;
                khuyenmai = 0;
            } else if (loai == 3 && ngay == 4)
            {
                giamgia = 0;
                khuyenmai = giagoc * 0.2m;
            }

            decimal tongtienve = giagoc - giamgia - khuyenmai + phuthu;

            Console.WriteLine("Giá vé gốc :" + giagoc.ToString("N0")+"VND");
            if (loai == 2) { Console.WriteLine("Giảm giá sinh viên(30%):-30,000 VND"); }
            Console.WriteLine("Phụ thu cuối tuần :" + phuthu.ToString("N0") + "VND");
            Console.WriteLine("Khuyến mãi :"+khuyenmai.ToString("N0") + "VND");
            Console.WriteLine("Tổng tiền vé :" + tongtienve.ToString("N0") + "VND");
            Console.ReadKey();

            }
        }
    }

using System;
using System.Text;
namespace bai1
{
    class Program
    {
        static void bai_1()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            decimal diencu = decimal.Parse(Console.ReadLine()!);

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            decimal dienmoi = decimal.Parse(Console.ReadLine()!);

            if (dienmoi < diencu)
            {
                Console.WriteLine("Lỗi: Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                return;
            }

            decimal dienTieuThu = dienmoi - diencu;

            decimal giaBac1 = 1.806m;
            decimal giaBac2 = 1.866m;
            decimal giaBac3 = 2.167m;
            decimal giaBac4 = 2.729m;
            decimal giaBac5 = 3.050m;

            decimal tienDien = 0;
            decimal soDienConLai = dienTieuThu;

            if (soDienConLai > 0)
            {
                decimal bac1 = Math.Min(soDienConLai, 50);
                tienDien += bac1 * giaBac1;
                soDienConLai -= bac1;
            }
            if (soDienConLai > 0)
            {
                decimal bac2 = Math.Min(soDienConLai, 50);
                tienDien += bac2 * giaBac2;
                soDienConLai -= bac2;
            }
            if (soDienConLai > 0)
            {
                decimal bac3 = Math.Min(soDienConLai, 100);
                tienDien += bac3 * giaBac3;
                soDienConLai -= bac3;
            }
            if (soDienConLai > 0)
            {
                decimal bac4 = Math.Min(soDienConLai, 100);
                tienDien += bac4 * giaBac4;
                soDienConLai -= bac4;
            }
            if (soDienConLai > 0)
            {
                tienDien += soDienConLai * giaBac5;
            }
            decimal thueVAT = tienDien * 0.08m;
            decimal tongThanhToan = Math.Round(tienDien + thueVAT, 3);
            tienDien = Math.Round(tienDien, 3);
            thueVAT = Math.Round(thueVAT, 3);

            Console.WriteLine($"Số điện tiêu thụ: {dienTieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien} VND");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT} VND");
            Console.WriteLine($"Tổng thanh toán: {tongThanhToan} VND");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            bai_1();




        }
    }
}




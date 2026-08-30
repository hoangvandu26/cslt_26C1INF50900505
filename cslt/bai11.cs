using System;
using System.Text;

namespace bai11

{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số tiền gửi (VND):");
            decimal p = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập lãi suất năm (%/năm):");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Nhập kỳ hạn gửi (tháng):");
            int n = int.Parse(Console.ReadLine());

            decimal lai_don = p * ((decimal)r / 100) * (n / 12m);
            double lai_kep = (double)p * (Math.Pow((1 + (r / 100) / 12),n)-1);
            decimal laikep = (decimal)lai_kep;
            decimal chenh_lech = laikep - lai_don;
            Console.WriteLine("Tổng tiền lãi(lãi đơn):" + lai_don.ToString("N0")+"VND");
            Console.WriteLine("Tổng tiền lãi(lãi kép):" + laikep.ToString("N0")+"VND");
            Console.WriteLine("Lợi nhuận chênh lệch:"+ chenh_lech.ToString("N0")+"VND");

        }
    }
}

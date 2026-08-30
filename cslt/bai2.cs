using System;
using System.Text;
namespace bai2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập chiều cao (m): ");
            double chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Nhập cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());

            double bmi = canNang / (chieuCao * chieuCao);

            string phanLoai;
            if (bmi < 18.5)
                phanLoai = "Gầy (Thiếu cân)";
            else if (bmi < 23.0)
                phanLoai = "Bình thường (Lý tưởng)";
            else if (bmi < 25.0)
                phanLoai = "Thừa cân (Tiền béo phì)";
            else
                phanLoai = "Béo phì";

            double canMin = 18.5 * chieuCao * chieuCao;
            double canMax = 22.9 * chieuCao * chieuCao;

            Console.WriteLine();
            Console.WriteLine("Chỉ số BMI của bạn: " + bmi.ToString("F2"));
            Console.WriteLine("Phân loại sức khỏe: " + phanLoai);
            Console.WriteLine("Cân nặng lý tưởng: từ " + canMin.ToString("F2") + " kg đến " + canMax.ToString("F2") + " kg");
        }
    }
}
using System;
using System.Text;

namespace bai5
{
    class Program
    {
   static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập điểm môn Lập trình c# (Thang điểm 10):");
            double diem1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Số tín chỉ học :");
            int tc1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm môn Toán rời rạc (Thang điểm 10):");
            double diem2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Số tín chỉ học :");
            int tc2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm môn Tiếng anh (Thang điểm 10):");
            double diem3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Số tín chỉ học :");
            int tc3 = int.Parse(Console.ReadLine());

            double diemtb = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3) / (tc1 + tc2 + tc3);
            char diem_chu;
            double thang_diem;
            string xep_loai;
            if(diemtb > 8.5)
            {
                diem_chu = 'A';
                thang_diem = 4.0;
                xep_loai = "Xuất sắc";
            }
            else if(diemtb > 7.0)
            {
                diem_chu = 'B';
                thang_diem = 3.0;
                xep_loai = "Khá";

            }
            else if(diemtb > 5.5)
            {
                diem_chu = 'C';
                thang_diem = 2.0;
                xep_loai = "Trung bình";

            }
            else if(diemtb > 4.0)
            {
                diem_chu = 'D';
                thang_diem = 1.0;
                xep_loai = "Yếu";

            }
            else
            {
                diem_chu = 'F';
                thang_diem = 0.0;
                xep_loai = "Kém(Trượt)";

            }

            Console.WriteLine("Điểm TB thang 10 :"+diemtb.ToString("F2"));
            Console.WriteLine("Điểm chữ quy đổi :"+diem_chu);
            Console.WriteLine("Điểm GPA thang 4 :"+thang_diem.ToString("F1"));
            Console.WriteLine("Xếp loại học lực :"+xep_loai);


        }
}
}
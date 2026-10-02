using System;
using System.Text;

namespace baitap04
{
    class baitap4_if_else
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //bai01();
            //bai02();
            //bai03();
            //bai04();
            //bai05();
            //bai06();
            //bai07();
            //bai08();
            //bai09();
            //bai10();
            //bai11();


            Console.ReadKey();
        }

        static void bai01()
        {
            Console.Write("Nhập độ tuổi của bạn:");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập thời gian chiếu bộ phim bạn muốn xem:");
            int gio = int.Parse(Console.ReadLine());
            decimal giave = 0;

            if (tuoi < 12 || tuoi > 60)
            {
                giave = 50000;
            }
            else if (gio < 17)
            {
                giave = 80000;
            }
            else { giave = 110000; }
            Console.Write("Gía vé của bạn:" + giave.ToString("N0") + "VND");

        }
        static void bai02()
        {
            Console.WriteLine("Các vai trò:\n");
            Console.WriteLine("ADMIN\t\tMANAGER\t\tEMPLOYEE\tGUEST\n");
            Console.WriteLine("Vai trò của bạn là:");
            string role = Console.ReadLine();

            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("[Trạng thái]:Toàn quyền quản trị hệ thống."); break;
                case "MANAGER":
                    Console.WriteLine("[Trạng thái]:Quyền quản lý nhân sự và xem báo cáo."); break;
                case "EMPLOYEE":
                    Console.WriteLine("[Trạng thái]:Quyền tạo và chỉnh sửa hồ sơ cá nhân."); break;
                case "GUEST":
                    Console.WriteLine("[Trạng thái]:Chỉ có quyền xem thông tin công khai."); break;
                default:
                    Console.WriteLine("[Trạng thái]:Mã vai trò không hợp lệ!."); break;

            }
        }
        static void bai03()
        {
            Console.Write("Nhập số dư tài khoản của bạn:");
            decimal sodu = decimal.Parse(Console.ReadLine());
            decimal rut;
            bool hople;
            bool hople1;
            bool hople2;
            bool hople3;
            do
            {
                Console.Write("Nhập số tiền bạn muốn rút:");
                hople = decimal.TryParse(Console.ReadLine(), out rut) && rut > 0;
                if (!hople)
                {
                    Console.Write("Số tiền rút phải lớn hơn 0! ");

                }
                decimal x = rut % 50000;
                hople1 = x == 0;
                if (!hople1)
                {
                    Console.Write("Số tiền rút phải là bội số của 50,000 VNĐ! ");
                }
                hople2 = rut < sodu;
                if (rut > sodu)
                {
                    Console.Write("Số tiền rút không vượt quá số dư hiện tại! ");
                }
                hople3 = rut <= 5000000;
                if (!hople3)
                {
                    Console.WriteLine("Hạn mức rút tối đa 5,000,000 VNĐ / lần! ");
                }
            } while (!hople || !hople1 || !hople2 || !hople3);
            Console.WriteLine("Số dư:" + sodu.ToString("N0") + " VND");
            Console.WriteLine("Số tiền rút:" + rut.ToString("N0") + " VND");
            Console.WriteLine("Giao dịch thành công. Số dư còn lại:" + (sodu - rut).ToString("N0") + " VND");
        }
        static void bai04()
        {
            Console.WriteLine("Khách hàng vui lòng bấm phím từ 0 đến 4:");
            Console.WriteLine("0: Quay lại menu chính.");
            Console.WriteLine("1: Gặp tổng đài viên tư vấn thẻ.");
            Console.WriteLine("2: Tra cứu số dư tài khoản.");
            Console.WriteLine("3: Báo khóa thẻ khẩn cấp.");
            Console.WriteLine("4: Tra cứu tỷ giá ngoại tệ.");
            Console.Write("Quý khách chọn:\t");
            bool hople;
            int luachon;
            do
            {
                hople = int.TryParse(Console.ReadLine(), out luachon) && luachon >= 0 && luachon <= 4;
                if (!hople)
                {
                    Console.Write("Lựa chọn không hợp lệ. Vui lòng thử lại!:\t");
                }
            } while (!hople);
            Console.WriteLine("\n");
            switch (luachon)
            {
                case 0: Console.WriteLine("[Tổng đài]: Yêu cầu Quay lại menu chính đã được ghi nhận."); break;
                case 1: Console.WriteLine("[Tổng đài]: Yêu cầu Gặp tổng đài viên tư vấn thẻ đã được ghi nhận."); break;
                case 2: Console.WriteLine("[Tổng đài]: Yêu cầu Tra cứu số dư tài khoản đã được ghi nhận."); break;
                case 3: Console.WriteLine("[Tổng đài]: Yêu cầu Báo khóa thẻ khẩn cấp đã được ghi nhận."); break;
                case 4: Console.WriteLine("[Tổng đài]: Yêu cầu Tra cứu tỷ giá ngoại tệ đã được ghi nhận."); break;
                default: Console.WriteLine("Lỗi!"); break;
            }
        }
        static void bai05()
        {
            Console.Write("Nhập số km di chuyển: ");
            int s;
            bool hople;
            do
            {
                hople = int.TryParse(Console.ReadLine(), out s) && s > 0;
                if (!hople) { Console.WriteLine("Lỗi! Vui lòng nhập lại: "); }
            } while (!hople);
            decimal giamgia = 0;
            decimal tt = 0;

            if (s > 30) { giamgia = 0.1m; }

            if (s == 1) { tt = 15000; }
            else if (s < 10) { tt = (s - 1) * 12000 + 15000; }
            else { tt = 15000 + (9 * 12000) + (s - 9) * 10000; }
            Console.WriteLine("Tổng tiền trước giảm:" + tt);
            Console.WriteLine("Khuyến mãi (10%):- " + (giamgia *= tt));
            Console.WriteLine("Thành tiền:" + (tt - giamgia));
        }
        static void bai06()
        {
            Console.WriteLine("1: Pending\n2: Processing\n3: Shipped\n4: Delivered\n5: Cancelled\nNhập mã trạng thái đơn hàng: ");
            string ma = Console.ReadLine();

            switch (ma)
            {
                case "1":
                    Console.WriteLine("[Thông báo]:Chờ xác nhận thanh toán."); break;
                case "2":
                    Console.WriteLine("[Thông báo]:Đang đóng gói và bàn giao đơn vị vận chuyển"); break;
                case "3":
                    Console.WriteLine("[Thông báo]:Đơn hàng đang trên đường giao đến bạn"); break;
                case "4":
                    Console.WriteLine("[Thông báo]:Đơn hàng đã hoàn thành. Cảm ơn bạn!"); break;
                case "5":
                    Console.WriteLine("[Thông báo]:Đơn hàng đã hủy. Xuất phiếu hoàn tiền."); break;
                default:
                    Console.WriteLine("[Thông báo]:Lỗi không thể xác nhận"); break;
            }
        }
        static void bai07()
        {
            Console.Write("Nhập chiều cao(m): ");
            double h = float.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng(kg): ");
            double w = float.Parse(Console.ReadLine());
            double BMI = (w / Math.Pow(h, 2));
            if (BMI < 18.5) { Console.WriteLine($"BMI: {BMI:F2} - Đánh giá:Bạn gầy - Nên bổ sung dinh dưỡng."); }
            else if (BMI < 25) { Console.WriteLine($"BMI: {BMI:F2} - Đánh giá:Cân đối - Tiếp tục duy trì."); }
            else if (BMI < 30) { Console.WriteLine($"BMI: {BMI:F2} - Đánh giá:Thừa cân - Nên tăng cường luyện tập."); }
            else { Console.WriteLine($"BMI: {BMI:F2} - Đánh giá:Béo phì - Cần sự tư vấn từ bác sĩ."); }
        }
        static void bai08()
        {
            Console.Write("Nhập loại xe (\"BIKE\" hoặc \"CAR\") : ");
            string loaixe = Console.ReadLine();
            Console.Write("Nhập thời gian gửi (1: Ban ngày, 2: Ban đêm): ");
            int tg = int.Parse(Console.ReadLine());
            decimal tien=0;
            switch (loaixe) 
            {
                case "BIKE":
                    if (tg == 1) { tien = 5000; }
                    else { tien = 10000; };break;
                case "CAR":
                    if (tg == 1) { tien = 30000; }
                    else { tien = 60000; }
                    ; break;
                default: Console.WriteLine("Không thể xác định!");break;
            }
            string tg1;
            if (tg == 1) { tg1 = "Ban ngày"; } else { tg1 = "Ban đêm"; }
            Console.WriteLine($"Phí gửi xe {loaixe} ({tg1}): {tien} VNĐ");
        }
        static void bai09()
        {
            Console.Write("Nhập điểm trung bình tích lũy(GPA:hệ 4.0): ");
            double GPA = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Điểm rèn luyện (DRL: hệ 100): ");   
            double DRL = double.Parse(Console.ReadLine());
            if (GPA >= 3.6 && DRL >= 90) { Console.WriteLine("Học bổng Xuất sắc (Mức 100%)."); }
            else if (GPA >= 3.2 && DRL >= 80) { Console.WriteLine("Học bổng Khá/Giỏi (Mức 50%)."); }
            else { Console.WriteLine("Không đạt học bổng."); };
        }
        static void bai10()
        {
            Console.Write("Nhập số tiền(VND): ");
            decimal tien = decimal.Parse(Console.ReadLine());
            Console.Write("Nhập ngoại tệ muốn đổi(Mã ngoại tệ(\"USD\", \"EUR\", \"JPY\"): ");
            string ngoaite = Console.ReadLine();
            switch (ngoaite)
            {
                case "USD":tien /= 25400;break;
                case "EUR":tien /= 27200;break;
                case "JPY":tien /= 165;break;
                default: Console.WriteLine("Lỗi! Không thể xác định?");break;
            }
            Console.WriteLine($"Số tiền sau quy đổi: {tien:F2} {ngoaite}");

        }
        static void bai11()
        {
            Console.Write("Nhập số kWh tiêu thụ trong tháng: ");
            int sodien = int.Parse(Console.ReadLine());
            decimal tien = 0;
            int muc1 = 1806;
            int muc2 = 1866;
            int muc3 = 2167;
            if(sodien <= 50) 
            { tien = sodien * muc1;
              Console.WriteLine($"Tổng tiền điện phải thanh toán: {tien.ToString("N0")} VNĐ");
              Console.WriteLine($"(Chi tiết: {sodien} * {muc1} = {tien.ToString("N0")})");
            }
            else if(sodien <= 100) 
            { tien = (sodien - 50) * muc2 + (50 * muc1); 
            Console.WriteLine($"Tổng tiền điện phải thanh toán: {tien.ToString("N0")} VNĐ");
            Console.WriteLine($"(Chi tiết: 50 * {muc1} + {sodien - 50} * {muc2} = {tien.ToString("N0")})");
            }
            else 
            { tien = 50 * muc1 + 50 * muc2 + (sodien - 100) * muc3; 
            Console.WriteLine($"Tổng tiền điện phải thanh toán: {tien.ToString("N0")} VNĐ");
            Console.WriteLine($"(Chi tiết: 50 * {muc1} + 50 * {muc2} + {sodien - 100} * {muc3} = {tien.ToString("N0")})");
            }            
        }

    }
}

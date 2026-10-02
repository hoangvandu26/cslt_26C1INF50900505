using System;
using System.Text;
namespace game {
class game_doan_so{
    static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool off_game;
            long tien = 10000000;
            do
            {   if (tien <= 10000) { Console.WriteLine("Bạn đã hết tiền! Vui lòng nạp thêm."); off_game = true; break; }
                int level = chon_muc_do();

                int so_lan_doan = 0;
                if (level == 1)
                {
                    Console.WriteLine("\nMức độ: Dễ\nĐoán số từ 1 đến 100\nSố lần đoán tối đa: 9");
                    so_lan_doan = 9;
                }
                else if (level == 2)
                {
                    Console.WriteLine("\nMức độ: Trung bình\nĐoán số từ 1 đến 100\nSố lần đoán tối đa: 6");
                    so_lan_doan = 6;
                }
                else if (level == 3)
                {
                    Console.WriteLine("\nMức độ: Khó\nĐoán số từ 1 đến 100\nSố lần đoán tối đa: 4");
                    so_lan_doan = 4;
                }

                Random rnd = new Random();
                int ket_qua = rnd.Next(1, 100);
                
                long tien_cuoc;
                bool hople;
                Console.WriteLine($"Số tiền đang có: {tien.ToString("N0")} VND");
                Console.WriteLine("Chọn số tiền muốn cược (Lưu ý: Số tiền cược phải lớn hơn 10 000 VND và không vượt quá số tiền của bạn!) ");
                do
                {
                    Console.Write($"Bạn cược: ");
                    hople = long.TryParse(Console.ReadLine(), out tien_cuoc) && tien_cuoc >= 10000 && tien_cuoc <= tien;
                    if (!hople) { Console.WriteLine("Vui lòng chọn số tiền cược phù hợp!"); }
                } while (!hople);

                int so_chon = 0;
                bool end = false;
                do
                {
                    Console.Write("\nBạn chọn số: ");
                    so_chon = int.Parse(Console.ReadLine());
                    so_lan_doan--;
                    if (so_chon == ket_qua)
                    {
                        Console.WriteLine($"Kết quả: {ket_qua}");
                        Console.WriteLine("Chúc mừng bạn đã chọn đúng!");
                        if (level == 1) { tien = tien + ((tien_cuoc) / 2); }
                        else if (level == 2) { tien += (tien_cuoc); }
                        else if (level == 3) { tien += (tien_cuoc) * 3; }
                        end = true;
                    }
                    else if (so_chon < ket_qua)
                    {
                        Console.WriteLine("Chưa chính xác");
                        Console.WriteLine($"Bạn còn {so_lan_doan} lần đoán!");
                        Console.WriteLine("Gợi ý: Hãy chọn số lớn hơn!\n");

                    }
                    else if (so_chon > ket_qua)
                    {
                        Console.WriteLine("Chưa chính xác");
                        Console.WriteLine($"Bạn còn {so_lan_doan} lần đoán!");
                        Console.WriteLine("Gợi ý: Hãy chọn số nhỏ hơn!\n");

                    }

                    if (so_lan_doan == 0 && so_chon != ket_qua)
                    {
                        Console.WriteLine("Bạn đã thua cuộc!");
                        Console.WriteLine("Kết quả quay số: " + ket_qua);
                        if (level == 1) { tien -= (tien_cuoc) / 2; }
                        else if (level == 2 || level == 3) { tien -= (tien_cuoc); }
                        end = true;
                    }

                } while (!end);
                Console.WriteLine($"Tổng số tiền của bạn: {tien.ToString("N0")} VND\n");
                Console.WriteLine("Bạn có muốn tiếp tục chơi?\nChọn:");
                Console.WriteLine("1 : Tiếp tục.");
                Console.WriteLine("2 : Thoát game.");
                int lua_chon = int.Parse(Console.ReadLine());
                if(lua_chon ==1) { off_game = false; }
                else if(lua_chon ==2) { off_game = true; }
                else { Console.WriteLine("Lỗi!"); off_game = true; }
                
            } while (!off_game);
        }

        static int chon_muc_do()
        {
            Console.WriteLine("GAME ĐOÁN SỐ");
            Console.WriteLine("Các mức độ chơi:");
            Console.WriteLine("1: Dễ\n   Được đoán tối đa 9 lần.\n   Số tiền thắng cược nhận được bằng 1/2 số tiền đặt cược.\n");
            Console.WriteLine("2: Trung bình\n   Được đoán tối đa 6 lần.\n   Số tiền thắng cược nhận được bằng số tiền đặt cược.\n");
            Console.WriteLine("3: Khó\n   Được đoán tối đa 4 lần.\n   Số tiền thắng cược nhận được bằng 3 lần số tiền đặt cược.\n");
            int muc_do;
            bool hople;
            do
            {
                Console.Write("Chọn mức độ muốn chơi ( 1 / 2 / 3 ): ");
                hople = int.TryParse(Console.ReadLine(), out muc_do) && (muc_do == 1 || muc_do == 2 || muc_do == 3);
                if (!hople) { Console.WriteLine("Vui lòng chọn theo hưỡng dẫn!"); }
            } while (!hople);
            return muc_do;
        }

    }
}



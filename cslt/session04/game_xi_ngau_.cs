using System;
using System.Text;
using System.Collections.Generic;
namespace game_xi_ngau
{
    class game_xi_ngau_
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            game_xi_ngau();
        }

        public static void game_xi_ngau() {
            long tien = 2_000_000;
            int so_lan_choi = 0;
            int so_lan_thang = 0;
            int so_lan_thua = 0;
            bool off = false;
            do
            {
                so_lan_choi++;
                Console.WriteLine($"Bạn đang có: {tien.ToString("N0")} VND");
                Console.Write("Bạn đặt cược bao nhiêu?: ");

                bool hople;
                long tien_dat_cuoc;
                do
                {
                    hople = long.TryParse(Console.ReadLine(), out tien_dat_cuoc) && tien_dat_cuoc > 1000 && tien_dat_cuoc <= tien;
                    if (!hople) { Console.WriteLine("Vui lòng nhập số tiền hợp lệ( Tối thiểu 1000 VND và không vượt quá số tiền của bạn):"); }

                } while (!hople);

                Random gieo_xuc_xac = new Random();
                int xucxac1 = gieo_xuc_xac.Next(1, 7);
                int xucxac2 = gieo_xuc_xac.Next(1, 7);
                int sum = xucxac1 + xucxac2;


                string doan_kq;
                do
                {
                    Console.Write("Bạn đoán Tài(T), Xỉu(X) hay Lục(L):");
                    doan_kq = Console.ReadLine().ToLower();
                    if (doan_kq != "t" && doan_kq != "x" && doan_kq != "l") { Console.WriteLine("Vui lòng chọn theo hưỡng dẫn!"); }
                    else { break; }
                } while (true);

                string kq = "";
                if (sum > 6) { kq = "t"; }
                else if (sum < 6) { kq = "x"; }
                else if (sum == 6) { kq = "l"; }

                Console.WriteLine("\nMở bát:");
                Console.WriteLine($"xúc xắc 1: {xucxac1}");
                Console.WriteLine($"Xúc xắc 2: {xucxac2}");
                Console.WriteLine($"Tổng : {sum}\n");

                if (doan_kq == kq && kq == "l")
                {
                    Console.WriteLine("Chúc mừng bạn chiến thắng giải đặc biệt!");
                    tien += (tien_dat_cuoc * 3);
                    Console.WriteLine($"Tổng số tiền hiện tại: {tien.ToString("N0")} VND");
                }

                else if (doan_kq == kq)
                {
                    Console.WriteLine("Chúc mừng bạn đoán đúng!");
                    tien += tien_dat_cuoc;
                    Console.WriteLine($"Tổng số tiền hiện tại: {tien.ToString("N0")} VND");
                    so_lan_thang++;
                }
                else if (doan_kq != kq)
                {
                    Console.WriteLine($"Bạn thua cược! Số tiền còn lại:{(tien -= tien_dat_cuoc).ToString("N0")} VND");
                    so_lan_thua++;
                }
                 
                if(tien < 1000)
                {
                    Console.WriteLine("Bạn đã thua hết tiền, vui lòng nạp thêm!\n");
                    off = true;
                    break;
                }



                Console.WriteLine("Bạn muốn:");
                Console.WriteLine("Chơi tiếp(y):");
                Console.WriteLine("Nghỉ chơi(n):");
                string tiep_tuc = Console.ReadLine();
                
                if (tiep_tuc == "y") { }
                else if (tiep_tuc == "n")
                { off = true; }
            } while (!off);

                Console.WriteLine("Thông tin người chơi:");
                Console.WriteLine($"Số lần chơi:{so_lan_choi} ");
                Console.WriteLine($"Số lần thắng: {so_lan_thang}");
                Console.WriteLine($"Số lần thua: {so_lan_thua}");
                Console.WriteLine($"Số tiền hiện có: {tien.ToString("N0")} VND");

            
            
        
        }

    }
}
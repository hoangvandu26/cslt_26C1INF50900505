using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai05
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi để đảo ngược: ");
            string chuoi_ban_dau = Console.ReadLine();
            Console.WriteLine($"Chuỗi sau khi đảo ngược : {dao_nguoc_chuoi(chuoi_ban_dau)}");
        }
        static string dao_nguoc_chuoi(string chuoi)
        {    
            char[] ky_tu =chuoi.ToCharArray();
            Array.Reverse(ky_tu);
            return new string(ky_tu); 
        }
    }
}

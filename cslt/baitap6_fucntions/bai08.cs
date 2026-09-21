using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap6_fucntions
{
    internal class bai08
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi ký tự: ");
            string chuoi = Console.ReadLine();
            Console.Write("Số nguyên âm trong chuỗi bạn vừa nhập: "+so_nguyen_am(chuoi));

        }
        static int so_nguyen_am(string c)
        {
            int so = 0;
            char[] ky_tu=c.ToCharArray();
            for (int i=0; i < ky_tu.Length; i++) 
            {
                if (ky_tu[i] == 'a' || ky_tu[i] == 'o' || ky_tu[i] == 'e' || ky_tu[i] == 'i' || ky_tu[i] == 'u') 
                { so++; }
                
            }
            return so;
        }
    }
}

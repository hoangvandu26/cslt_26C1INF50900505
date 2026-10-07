using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Net;
using System.Text;

namespace cslt.baitap9_string
{
    internal class ex
    {
        static void Main()
        {   Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một chuỗi: ");
            string chuoi = Console.ReadLine();

            ex01(chuoi);
            ex02(chuoi);
            ex03(chuoi);
            ex04(chuoi);
            ex05(chuoi);
            ex06(chuoi);
            ex07(chuoi);
        }

        static void ex01(string chuoi)//to input a string and print it.
        {
            Console.WriteLine($"Chuỗi bạn vừa nhập: {chuoi}");
        }

        static void ex02(string chuoi)//to find the length of a string without using a library function.
        {
            int dem = 0;
            foreach(int c in chuoi)
            {
                dem++;
            }
            Console.Write("Độ dài chuỗi vừa nhập: ");
            Console.WriteLine(dem);
            Console.WriteLine();
            
        }

        static void ex03(string chuoi)//to separate individual characters from a string.
        {
            Console.Write("Tách các ký tự của chuỗi: ");
            chuoi.Split(" ");
            foreach (char i in chuoi)
            {
                if(i == ' '){ continue;}
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }

        static void ex04(string chuoi)//to print individual characters of the string in reverse order.
        {
            Console.Write("Các ký tự của chuỗi theo thứ tự ngược lại: ");
            for (int i = chuoi.Length-1; i >=0; i--)
            {
                Console.Write($"{chuoi[i]}");
            }
            Console.WriteLine("\n");
        }

        static void ex05(string chuoi)//to count the total number of words in a string.
        {
            
            int dem = 0;
            foreach(char c in chuoi)
            {
                if(c == ' ') {  continue;}
                dem++;
            }
            Console.Write($"Tổng số từ trong chuỗi: {dem}");
            Console.WriteLine();
        }

        static void ex06(string chuoi)//to count the number of alphabets, digits and special characters in a string.
        {
            int kytu = 0;
            int so = 0;
            int kytukhac = 0;
            foreach (char c in chuoi)
            {
                if (c == ' ') { continue; }
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) { kytu++; }
                else if (c >= '0' && c <= '9') { so++; }
                else { kytukhac++; }
            }
            Console.WriteLine($"Số ký tự trong chuỗi: {kytu}");
            Console.WriteLine($"Số số trong chuỗi: {so}");
            Console.WriteLine($"Số ký tự đặc biệt trong chuỗi: {kytukhac}");
            Console.WriteLine();
        }

        static void ex07(string chuoi)//to check whether a given substring is present in the given string.
                                      //to search for the position of a substring within a string.
        {
            Console.Write("Nhập một từ để kiểm tra có tồn tại trong chuỗi hay không: ");
            string tu = Console.ReadLine();
            bool check = false;
            int vitri = -1;
            for(int i = 0; i < chuoi.Length-tu.Length; i++)
            {
                bool co = true;
                for (int j = 0; j < tu.Length; j++)
                {
                    if (chuoi[i+j] != tu[j])
                    {
                        co = false; break;
                    }
                }
                if (co) { check = true; vitri = i+1; break; }
            }
            Console.WriteLine(check);
            Console.WriteLine($"Vị trí tìm thấy: {vitri}");
        }

    }
}

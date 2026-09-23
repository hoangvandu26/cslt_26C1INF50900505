using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class ex4
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(1, 50);
            }
            //
            Console.Write("\t\t Mảng: ");
            foreach (int i in arr)
            {   Console.Write(i + " "); }

            Console.Write("\t|Nhập phần tử muốn xóa khỏi mảng: ");
            int xoa = int.Parse(Console.ReadLine());
            bool kq = true;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] == xoa) 
                { for(int j = i+1;j < 10; j++)
                    {
                        arr[i] = arr[j];
                        i++;
                    }
                    break;
                }
                else { kq = false; }
            }
            
            if(kq== true)
            {   int[] arr1 = new int[9];
                for(int i = 0;i < 9; i++)
                {
                    arr1[i] = arr[i];
                }
                Console.Write("Đã xóa! Mảng hiện tại: ");
                foreach(int i in arr1)
                {Console.Write(i + " ");}
            }
            else { Console.WriteLine("\nPhần tử không tồn tại trong mảng!"); }
            Console.ReadKey();  
        }
    }
}

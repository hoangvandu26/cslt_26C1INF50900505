using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class array2d
    {/*Create a program with following functions
-Create an integer matrix N x M (N,M was prompted from user) randomly.
-Print the matrix.
-Print the ith row/column. (i was prompted from user)
-Find the max value of the matrix.
-Find the min value of ith row/col of the matrix.
-Transpose the matrix.
-Print the main/secondary diagonal values of the matrix.(square maxtrix)*/
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số dòng của ma trận: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận: ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(1, 20);
                }
            }
            Console.WriteLine($"\nMa trận {n} * {m}:");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }

            int max = arr[0,0];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Giá trị lớn nhất trong mảng: {max}\n");
            Console.Write("Bạn muốn in hàng thứ mấy: ");
            int in_n = int.Parse(Console.ReadLine())-1;
            

            for(int i = 0; i< arr.GetLength(1); i++)
            {
                Console.Write(arr[in_n,i]+"\t");
            }
            Console.Write("\nBạn muốn in cột thứ mấy: ");
            int in_m = int.Parse(Console.ReadLine())-1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(arr[i, in_m]);
            }

            Console.Write("Tìm giá trị nhỏ nhất của hàng thứ: ");
            int min_n = int.Parse(Console.ReadLine()) - 1;
            int min_in_row = arr[min_n,0];
            for(int i = 0; i< arr.GetLength(1); i++)
            {
                if( arr[min_n,i] < min_in_row)
                {
                    min_in_row=arr[min_n,i];
                }
            }
            Console.WriteLine($"giá trị nhỏ nhất của hàng thứ {min_n+1} là :{min_in_row}");

            Console.Write("\nTìm giá trị nhỏ nhất của cột thứ: ");
            int min_m = int.Parse(Console.ReadLine()) - 1;
            int min_in_col = arr[0,min_m];
            for(int i = 0; i< arr.GetLength(0); i++)
            {
                if( arr[i,min_m] < min_in_col)
                {
                    min_in_col=arr[i,min_m];
                }
            }
            Console.WriteLine($"giá trị nhỏ nhất của cột thứ {min_m+1} là :{min_in_col}");


        }
    }
}

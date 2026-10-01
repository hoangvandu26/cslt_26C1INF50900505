using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.jagged_array
{
    internal class ex
    {   //1.Create a jagged array and initialize it using the following values for its rows and columns; Then, display it.
        static void Main()
        {   Console.OutputEncoding = Encoding.UTF8;
            //ex1();
            ex2();


        }

        static void ex2() 
        {
            

                Console.Write("Nhập số dòng cho ma trận jagged:");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Số cột tối thiểu cho ma trận jagged:");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Số cột tối đa cho ma trận jagged:");
                int m = int.Parse(Console.ReadLine());
                int[][] jag_arr = new int[row][];

                sinh_mang(jag_arr, row, n, m);

            static void sinh_mang(int[][] a,int r,int x,int y)
            {
                Random rnd = new Random();

                a = new int[r][];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    int length = rnd.Next(x, y);
                    a[i] = new int[length];
                    for (int j = 0; j < length; j++)
                    {
                        a[i][j] = rnd.Next(1, 20);
                    }
                }
                Console.WriteLine("Ma trận jagged:");
                foreach (int[] rows in a)
                {
                    foreach (int e in rows)
                    {
                        Console.Write(e + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                find(a);
                Console.WriteLine("\nMảng sau khi sắp sếp:");
                sort_array(a);
                foreach (int[] rows in a)
                {
                    foreach (int e in rows)
                    {
                        Console.Write(e + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void find(int[][] a)
            {
                int max = a[0][0];
                int min = a[0][0];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a[i].Length; j++)
                    {
                        if (a[i][j] > max) { max = a[i][j]; }
                        if (a[i][j] < min) { min = a[i][j]; }
                    }
                }
                Console.WriteLine("Phần tử lớn nhất trong mảng:"+max);
                Console.WriteLine("Phần tử nhỏ nhất trong mảng:"+min);
            }
            static void sort_array(int[][] a)
            {
                for(int i = 0;i < a.GetLength(0); i++)
                {
                    for(int j =0; j < a[i].Length; j++)
                    {
                        for(int k = j+1; k < a[i].Length; k++)
                        if (a[i][j] > a[i][k]) { swap(a, i, j, k); }
                    }
                }
            }
            static void swap(int[][] a,int i,int j,int k)
        {
            int temp = a[i][j];
            a[i][j] = a[i][k];
            a[i][k] = temp;
        }
        }
        static void ex1()
        {   int[][,] jagged_arr = new int[4][,];
            jagged_arr[0] = new int[1,5] {{1, 1, 1, 1, 1 }};
            jagged_arr[1] = new int[1,2] {{2,2}};
            jagged_arr[2] = new int[1,3] {{3,3,3}};
            jagged_arr[3] = new int[1,2] {{4,4}};

            print_arr(jagged_arr);


            static void print_arr(int[][,] arr)
            {
                foreach (int[,] i in arr)
                {
                    foreach (int j in i)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        
    }
}

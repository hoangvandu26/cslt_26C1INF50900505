using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace cslt.jagged_array
{
    internal class ex
    {   
        static void Main()
        {   Console.OutputEncoding = Encoding.UTF8;


            //ex1();
            //ex2();


        }

        static void ex3()
        {
            string[][,] member =  new string [3][,];
            static void thong_tin_nhom(string[][,] nhom)
            {
                nhom[0] = new string[5, 3]
                {
                    {"1001","Nguyen van A","13"},
                    {"1002","Nguyen van B","19"},
                    {"1003","Nguyen van C","3"},
                    {"1004","Nguyen van D","20"},
                    {"1005","Nguyen van E","21"}
                };
                nhom[1] = new string[3, 3]
                {
                    {"1006","Nguyen van F","7"},
                    {"1007","Nguyen van G","29"},
                    {"1008","Nguyen van H","13"},
                };
                nhom[2] = new string[6, 3]
                {
                    {"1009","Nguyen van I","7"},
                    {"1010","Nguyen van J","8"},
                    {"1011","Nguyen van K","16"},
                    {"1012","Nguyen van L","26"},
                    {"1013","Nguyen van M","20"},
                    {"1014","Nguyen van N","25"}
                };
            }
            static void in_thong_tin(string[][,] nhom)
            {
                foreach (string[,] k in nhom)
                {
                    for(int i = 0; i< nhom.GetLength(1); i++)
                    {
                        Console.WriteLine($"ID: {k[i,0]} ; NAME: {k[i,1]} ; NO TASK: {k[i,2]} ;");
                    }
                }
            }
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
        static void ex1()//1.Create a jagged array and initialize it using the following values for its rows and columns; Then, display it.
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

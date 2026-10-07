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
            ex3();


        }

        static void ex3()
        {
            string[][,] member =  new string [3][,];
            thong_tin_nhom(member);

            bool hople = true;
            do
            {
                Console.Write("Menu:\t");
                Console.WriteLine("1 : Hiển thị thông tin tất cả các thành viên");
                Console.WriteLine("\t2 : Tìm thành viên");
                Console.WriteLine("\t3 : Hiển thị thông tin thành viên có số lượng công việc hoàn thành nhiều nhất");
                Console.WriteLine("\t4 : Thoát\n");
                Console.Write("Lựa chọn: ");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1: in_thong_tin(member); break;
                    case 2: tim_thong_tin_thanh_vien(member); break;
                    case 3: tim_task_cao_nhat(member); break;
                    case 4: hople = false; break;
                    default: Console.WriteLine("Something went wrong."); break;
                }
            } while (hople);
            
            
            
            


            static void thong_tin_nhom(string[][,] nhom)
            {
                nhom[0] = new string[5, 3]
                {
                    {"1001","Nguyen Van An","13"},
                    {"1002","Hoang Thi Ly","19"},
                    {"1003","Tran Tan Tai","3"},
                    {"1004","Nguyen Tuan Hung","20"},
                    {"1005","Phan Duc Anh","21"}
                };
                nhom[1] = new string[3, 3]
                {
                    {"1006","Ly Thi Nga","7"},
                    {"1007","Vi Ngoc Bao","29"},
                    {"1008","Nguyen Van Dat","13"},
                };
                nhom[2] = new string[6, 3]
                {
                    {"1009","Nong Minh Tan","7"},
                    {"1010","Lu Tuan Kiet","8"},
                    {"1011","Phan Hoang Quan","16"},
                    {"1012","Le Thi My","26"},
                    {"1013","Nguyen van Nhan","20"},
                    {"1014","Ho Ngoc Mai","25"}
                };
            }

            static void in_thong_tin(string[][,] nhom)
            {
                foreach (string[,] k in nhom)
                {
                    for(int i = 0; i< k.GetLength(0); i++)
                    {
                        Console.WriteLine($"ID: {k[i,0]}, Name: {k[i,1]} ,No task: {k[i,2]} .\n");
                    }
                }
            }

            static void tim_thong_tin_thanh_vien(string[][,] nhom)
            {
                Console.Write("Nhập ID thành viên cần tìm thông tin: ");
                string id = Console.ReadLine();
                for(int i = 0;i < nhom.Length; i++)
                {
                    for(int j =0;j < nhom[i].GetLength(0); j++)
                    {
                            if (nhom[i][j,0] == id)
                            {
                                Console.WriteLine($"\nID: {nhom[i][j,0]} , Name: {nhom[i][j,1]} , No task: {nhom[i][j,2]} .");break;
                            }
                    }
                }
                Console.WriteLine();
            }

            static void tim_task_cao_nhat(string[][,] nhom)
            {
                
                int max = 0;
                string[] thanh_vien = null;
                for (int i = 0; i < nhom.Length; i++)
                {
                    for (int j = 0; j < nhom[i].GetLength(0); j++)
                    {
                        int task = int.Parse(nhom[i][j, 2]);
                        if (task > max)
                        {
                            max = task;
                            thanh_vien = new string[3] { nhom[i][j,0] , nhom[i][j,1] , nhom[i][j, 2] };
                        }
                    }
                }
                Console.Write("Thành viên có số lượng công việc hoàn thành nhiều nhất: ");
                Console.WriteLine($"ID: {thanh_vien[0]} , Name: {thanh_vien[1]} , No task: {thanh_vien[2]}\n");
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

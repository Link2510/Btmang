﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Bài 1
            /*
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap gia tri vi tri {0}", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in ba1)
            {
                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(i);
            }
            */
            #endregion
            #region Bài 2
            /*
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap gia tri vi tri {0}", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = a.Length; i > 0; i--)
            {
                
                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(i);
            }
            */
            #endregion
            #region Bài 3
            
             int[] a = new int[10];
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap gia tri vi tri {0}", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (max <= a[i])
                    max = a[i];
            }
            int count = 0;
            while(max%10!=0)
            {
                count += 1;
                max = max / 10;
            }
            Console.WriteLine(count);
             for (int i = 0; i < a.Length; i++)
             {
                for (int j = 0; j < count+1; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("{0}",i);

             }
             Console.WriteLine();
             for (int i = 0; i < a.Length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < count; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("{0}", a[i]);
             }
            
            #endregion
            //Bài 4

            #region Bài 5

            #region a Tính tổng của mảng
            /*
            int Min = 0;
            int Max = 100;

            int[] a = new int[5];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(Min, Max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine("Tong cua mang tren la: {0}", sum);*/
            #endregion
            #region b Đếm các số bé hơn 10 trong mảng
            /*
             int Min = 0;
            int Max = 100;

            int[] a = new int[5];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(Min, Max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            int count=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]<10)
                {
                    count += 1;
                }
            }
            Console.WriteLine("So cac gia tri nho hon 10 la: {0}",count);*/
            #endregion
            #region c Tạo mảng B tính B[i] khi (0<=i<=19) với size là 20
            /*
            int[] a=new int[20]; 
            int[] b =new int[a.Length];
            int temp = 0;
            int Min = 0;
            int Max = 100;
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(Min, Max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            for (int i = 0; i < a.Length ; i++)
             {
                if (0<=a[i]&&a[i]<=19)
                {
                    for (int j = 0; j <=i; j++)
                    {
                        temp += a[j];
                    }
                   
                }
                b[i] = temp;
                temp = 0;
            }
            for (int i = 0; i < b.Length; i++)
             {
                if(b[i]==0)
                    Console.WriteLine("Khong thoa yeu cau");
                else
                 Console.WriteLine("Gia tri cua b tai vi tri {0} la {1}",b[i],i);
             }
            */
            #endregion
            #endregion
            #region Bài 6
            /*int count = 0;
            int[] a = new int[1000];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap gia tri cua vi tri thu {0}",i+1);
                a[i] = Int32.Parse(Console.ReadLine());
                if (a[i] == 0)
                    break;
                else
                    count += 1;
            }
            int[] b = new int[count];
            for (int i = 0; i < count; i++)
            {
                b[i] = a[i] * 2;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Gia tri tai {0} cua mang b la {1}",i,b[i]);
            }*/
            #endregion
            #region Bài 7
            /*int find;
            int[] a = new int[20];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next();
                Console.WriteLine("Vi tri thu {0} co gia tri", i+1);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Nhap so ban muon tim");
            find = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == find)
                {
                    Console.WriteLine("So ban tim co trong mang va co vi tri la {0}", i + 1);
                    count += 1;
                }
            }
            if (count == 0)
                Console.WriteLine("So ban tim khong co trong mang");
            */
            #endregion
            #region Bài 8 
            /* int vitri = 0;
             int giatri = 0;
             int[] a = new int[20];
             Random randNum = new Random();
             for (int i = 0; i < a.Length; i++)
             {
                 a[i] = randNum.Next();
                 Console.WriteLine("Vi tri thu {0} co gia tri", i);
                 Console.WriteLine(a[i]);
             }
             Console.ReadKey();
             Console.WriteLine();
             for (int i = 0; i < a.Length; i++)
             {
                 if(giatri<a[i])
                 {
                     vitri = i;
                     giatri = a[i];
                 }
             }
             Console.WriteLine("gia tri lon nhat la: {0} tai vi tri {1}",giatri,vitri);*/
            #endregion
        }

    }
}

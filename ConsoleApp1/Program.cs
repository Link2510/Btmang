﻿using System;
using System.Collections.Generic;

namespace FillandPrintAnArray
{
    class Program
    {
        static void Main(string[] args)
        {



            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Nhap gia tri vi tri {0}", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in a)
            {
                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(i);
            }


        }


    }


}

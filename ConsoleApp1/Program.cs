using System;
using System.Collections.Generic;

namespace FillandPrintAnArray
{
    class Program
    {
        public const int sizeOfArray = 10;
        static void Main(string[] args)
        {



            int[] a = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray ; i++)
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

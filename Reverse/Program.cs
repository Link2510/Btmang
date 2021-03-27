using System;

namespace Reverse
{
    class Program
    {
        public const int sizeOfArray = 10;
        static void Main(string[] args)
        {
            int[] a = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("Nhap gia tri vi tri {0}", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (int i = sizeOfArray-1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}

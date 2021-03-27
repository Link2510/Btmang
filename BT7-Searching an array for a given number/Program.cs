using System;

namespace BT7_Searching_an_array_for_a_given_number
{
    class Program
    {
        public const int sizeOfArray = 20;
        static void Main(string[] args)
        {
            int find;
            int[] a = new int[sizeOfArray];
            Random randNum = new Random();
            for (int i = 0; i < sizeOfArray; i++)
            {
                a[i] = randNum.Next();
                Console.WriteLine("Vi tri thu {0} co gia tri", i + 1);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Nhap so ban muon tim");
            find = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (a[i] == find)
                {
                    Console.WriteLine("So ban tim co trong mang va co vi tri la {0}", i + 1);
                    count += 1;
                }
            }
            if (count == 0)
                Console.WriteLine("So ban tim khong co trong mang");
        }
    }
}

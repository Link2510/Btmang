using System;

namespace Prettyprint02
{
    class Program
    {
        public const int sizeOfArray = 10;
        static void Main(string[] args)
        {
            int[] a = new int[sizeOfArray];
            int max = 0;
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("Nhap gia tri vi tri {0}", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (max <= a[i])
                    max = a[i];
            }
            int count = 0;
            while (max % 10 != 0)
            {
                count += 1;
                max = max / 10;
            }
            Console.WriteLine(count);
            for (int i = 0; i < sizeOfArray; i++)
            {

                for (int j = 0; j <= count; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("{0}", i);

            }
            Console.WriteLine();
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("-----");
            }
            Console.WriteLine();
            for (int i = 0; i < sizeOfArray; i++)
            {

                Console.Write("|");
                for (int j = 0; j < count; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("{0}", a[i]);

            }
            Console.WriteLine();
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("-----");
            }
            
        }
    }
}

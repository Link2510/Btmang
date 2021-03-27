using System;

namespace BT6_Copy_and_double
{
    class Program
    {
        public const int sizeOfArray = 1000;
        static void Main(string[] args)
        {
            int count = 0;
            int[] a = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("Nhap gia tri cua vi tri thu {0}", i + 1);
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
                Console.WriteLine("Gia tri tai {0} cua mang b la {1}", i, b[i]);
            }
        }
    }
}

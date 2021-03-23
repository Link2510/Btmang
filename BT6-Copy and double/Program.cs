using System;

namespace BT6_Copy_and_double
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] a = new int[1000];
            for (int i = 0; i < a.Length; i++)
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

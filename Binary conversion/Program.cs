using System;

namespace Binary_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[32];
            for (int i = 0; i < 32; i++)
            {
                a[i] = 0;
            }

            while (n != 0) 
            {
                    a[temp] = n % 2;
                    temp++;
                    n /= 2;             
            }
            int count = 0;
            for (int i = 31; i >= 0; i--)
            {
                if (count == 8)
                {
                    Console.Write(" ");
                    count = 0;
                }
                Console.Write(a[i]);
                count++;
            }
        }
    }
}

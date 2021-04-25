using System;

namespace Selection_Sort
{
    class Program
    {
        const int min = 1;
        const int max = 100;
        static void Swap(ref int a, ref int b)
        { 
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {

            int[] a = new int [30];
            Random randNum = new Random();
            for (int i = 0; i < 30; i++)
            {
                a[i] = randNum.Next(min, max);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int end = a.Length - 1;
            for (int i = 0; i <= end - 1; ++i)
            {
                int max_ind = 0;
                for (int j = i + 1; j <= end; ++j)
                {
                    if (a[max_ind] < a[j])
                    {
                        max_ind = j;
                    }

                    if (j == end)
                    {
                        Swap(ref a[max_ind], ref a[end]);
                        end -= 1;
                        i = -1;
                        
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}

using System;

namespace Cocktail_Sort
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            bool done = true;
            int[] array = { 5, 1, 6, 8, 10, 4 };
            while (done == true)
            {
                
                for (int i = 0; i < array.Length-1; ++i)
                {
                    
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                       
                    }
                }
                
                for (int i = array.Length - 1; i > 0; --i)
                {
                    if (array[i] > array[i - 1])
                    {
                        Swap(ref array[i], ref array[i - 1]);
                       
                    }
                }
            }
            foreach (int a in array)
            {
                Console.Write(a + "  ");
            }
        }
    }
}

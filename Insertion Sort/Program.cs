using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 5, 3, 1, 8, 7, 2, 4 };
            int temp_value = 0;
            for (int vitriduyet = 1; vitriduyet <= array.Length - 1; vitriduyet++)
            {
                temp_value = array[vitriduyet];
                int temp_ind = vitriduyet;
                while (temp_ind > 0 && array[temp_ind - 1] > temp_value)
                {
                    array[temp_ind] = array[temp_ind - 1];
                    temp_ind -= 1;
                }
                array[temp_ind] = temp_value;
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

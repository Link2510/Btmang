using System;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        
        const int sizeOfArray = 100000;
        static void Main(string[] args)
        {
            
            DoThoiGian();
        }
        static void Sort(int[] a)
        {
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i]<a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
            }
        }
       
        static void DoThoiGian()
        {
            Stopwatch st = new Stopwatch();
            st.Reset(); // reset thời gian
            st.Start(); // bắt đầu tính thời gian
            int max = int.MaxValue;
            int min = 1;
            int[] array = new int[sizeOfArray];
            Random randNum = new Random();
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = randNum.Next(min, max);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("After sort");
            Sort(array);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }


            st.Stop(); // kết thúc đo thời gian
            long timeelapsed = st.ElapsedMilliseconds; // thời gian thực hiện
            Console.WriteLine(timeelapsed);
        }
        
    }
}

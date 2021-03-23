using System;

namespace BT9_Test_subset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int[] b = new int[20];
            int Max = 10;
            int Min = 1;
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++) // Tạo ra mảng a với giá trị random
            {
                a[i] = randNum.Next(Min, Max);
                Console.WriteLine("Vi tri thu {0} cua mang 1 co gia tri", i);
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++) // Tạo ra mảng b với giá trị random
            {
                b[i] = randNum.Next(Min, Max);
                Console.WriteLine("Vi tri thu {0} cua mang 2 co gia tri", i);
                Console.WriteLine(b[i]);
            }
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] == a[i])
                    {
                        count += 1;
                        break;
                    }
                }

            }
            Console.WriteLine("-{0}", count);
            if (count == 20)
                Console.WriteLine("2 mang trung nhau");
            else
                Console.WriteLine("2 mang khong trung nhau");
        }
    }
}

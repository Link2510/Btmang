using System;

namespace BT8_Find_the_maximum_element_of_an_array
{
    class Program
    {
        public const int sizeOfArray = 20;
        static void Main(string[] args)
        {
            int vitri = 0;
            int giatri = 0;
            int[] a = new int[sizeOfArray];
            Random randNum = new Random();
            for (int i = 0; i < sizeOfArray; i++)
            {
                a[i] = randNum.Next();
                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            Console.WriteLine();
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (giatri < a[i])
                {
                    vitri = i;
                    giatri = a[i];
                }
            }
            Console.WriteLine("gia tri lon nhat la: {0} tai vi tri {1}", giatri, vitri);
        }
    }
}

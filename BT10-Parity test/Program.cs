using System;

namespace BT10_Parity_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so bat ki");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("Day la so chan");
            else
                Console.WriteLine("Day la so le");
        }
    }
}

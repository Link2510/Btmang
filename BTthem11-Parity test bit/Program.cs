using System;

namespace BTthem11_Parity_test_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so bat ki ");
            int n = int.Parse(Console.ReadLine());
            byte b = (byte)n;
            if ((b & 1) == 1)
                Console.WriteLine("Day la so le");
            else
            {
                Console.WriteLine("Day la so chan");
            }
            
        }
    }
}

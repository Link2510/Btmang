using System;

namespace BTthem14_Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int a;
            while (n>0)
            {
                a = n % 10;
                temp = (temp * 10 + a);
                n = n/10;
            }
            Console.WriteLine(temp);
        }
    }
}

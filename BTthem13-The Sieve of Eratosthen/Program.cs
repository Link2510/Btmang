using System;

namespace BTthem13_The_Sieve_of_Eratosthen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hay nhap so n:");
            int n = int.Parse(Console.ReadLine());
            if (n >= 2)
            {

                for (int i = 2; i < n; i++)
                {
                    if (Primality(i) == true)
                    {
                        Console.WriteLine(i);
                    }
                    else
                        continue;

                }
            }
            else
                Console.WriteLine("{0} khong duoc xet la so nguyen to",n);
        }
        public static bool Primality(int n)
        {
            int count = 0;
            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count += 1;
                    }
                }
            }
            if (count == 0)
            {
                return true;
            }
            return false;
        }
    }
}

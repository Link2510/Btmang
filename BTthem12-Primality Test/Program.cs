using System;

namespace BTthem12_Primality_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hay nhap 1 so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            if (n>0)
            {

                if(n>1)
                {     
                if (Primality(n) == true)
                {
                    Console.WriteLine("Day la so nguyen to");
                }
                else
                    Console.WriteLine("Day khong phai la so nguyen to");
                }
                else
                    Console.WriteLine("{0} khong duoc xet la so nguyen to",n);
            }           
            else
            {
                Console.WriteLine("Day la so am, hay khoi dong lai chuong trinh");
            }    
        }
        public static bool Primality(int n)
        {
            int count = 0;
            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n%i==0)
                    {
                        count += 1;
                    }
                }
            }
            if (count==0)
            {
                return true;
            }
            return false;
        }
    }
}

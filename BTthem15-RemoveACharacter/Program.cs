using System;


namespace BTthem15_RemoveACharacter
{
    class Program
    {
        public const int sizeOfArray = 10000;   
        static void Main(string[] args)
        {
            Console.Write("Nhap cau ban thich: ");
            string c = Console.ReadLine();
            char[] a=new char[sizeOfArray];
            for (int i = 0; i < c.Length; i++)
            {
                a[i] = c[i];
            }
            Console.Write("Nhap vao vi tri ban muon xoa trong cau: ");
            int n = int.Parse(Console.ReadLine());
            dCharacter(a, n);
            
        }
        static void dCharacter(char[] c, int n)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (i == n)
                {
                    continue;
                }
                else
                    Console.Write(c[i]);
            }
            
        }
    }
}

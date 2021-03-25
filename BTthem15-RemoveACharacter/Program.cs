using System;


namespace BTthem15_RemoveACharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap cau ban thich: ");
            string c = Console.ReadLine();
            Console.Write("Nhap vao vi tri ban muon xoa trong cau: ");
            int n = int.Parse(Console.ReadLine());
            while (n>=c.Length)
            {
                Console.WriteLine("Vi tri ban muon xoa khong co trong cau. Hay nhap lai");
                n = int.Parse(Console.ReadLine());
            }
            char[] tmp = c.ToCharArray();
            for (int i = 0; i < tmp.Length; i++)
            {
                if (i==n)
                {
                    tmp[i] =(char)0;
                }
            }
            tmp.ToString();
            Console.WriteLine(tmp);
           
        }
    }
}

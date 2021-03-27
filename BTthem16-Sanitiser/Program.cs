using System;

namespace BTthem16_Sanitiser
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap chuoi cua ban vao: ");
            char[] c = Console.ReadLine();
            foreach (char item in c)
            {
                Console.WriteLine(item);
            }
        }
    }
}

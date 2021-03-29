using System;

namespace BTthem16_Sanitiser
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Hay nhap chuoi cua ban vao: ");
            string tmp = Console.ReadLine();
            char[] ch = new char[tmp.Length];
            for (int i = 0; i < tmp.Length; i++)
            {
                ch[i] = tmp[i];
            }
            deleteNumberic(ch);
        }
        static void deleteNumberic (char[] a) 
        {
            for (int i = 0; i < a.Length; i++)
            {
               
                if ((a[i] >=(char)48) && (a[i] <= (char)57))
                {
                    a[i] = (char)0;
                }
                
            }
            foreach (char c in a)
            {
                Console.Write(c);
            }
        }
    }
}

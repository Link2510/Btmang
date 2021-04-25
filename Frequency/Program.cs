using System;

namespace LowerCase
{
    class Program
    {
        static void lowerCase(string a)
        {
            int n = a.Length;
            char[] ch = new char[n];
            for (int i = 0; i < n; i++)
            {
                ch[i] = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    ch[i] = (char)(ch[i] + 32);
                }
            }
            foreach (char c in ch)
            {
                Console.Write(c);
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            lowerCase(s);
        }
    }
}

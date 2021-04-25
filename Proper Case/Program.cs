using System;

namespace Proper_Case
{
    class Program
    {
        static void properCase(string a)
        {
            int n = a.Length;
            char[] ch = new char[n];
            for (int i = 0; i < n; i++)
            {
                ch[i] = a[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (ch[0] >= 'a' && ch[0] <= 'z')
                {
                    ch[0] = (char)(ch[0] - 32);
                    i = i + 1;
                }
                if (ch[i] == ' ')
                    if (ch[i + 1] >= 'a' && ch[i + 1] <= 'z')
                    {
                        ch[i + 1] = (char)(ch[i + 1] - 32);
                        i = i + 1;
                    }
            }
            foreach (char var in ch)
            {
                Console.Write(var);
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            properCase(s);
        }
    }
}

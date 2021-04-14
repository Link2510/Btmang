using System;

namespace palindrome
{
    class Program
    {
        static bool checkPalindrome(string inputString)
        {
            int n = inputString.Length / 2;
            int m = inputString.Length - 1;
            for (int i = 0; i <= n; i++)
            {
                if (inputString[i] != inputString[(m - i)])
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(checkPalindrome(s));
        }
    }
}

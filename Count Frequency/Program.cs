using System;
using System.Collections.Generic;

namespace Count_Frequency
{
    class Program
    {
        static string lowerCase(string a)
        {
            int n = a.Length;
            string s = ""; // Chuỗi s chứa các phần tử đã chuyển về lowerCase
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    int x = a[i] + 32; // Chuyển về Ascii table để dễ xử lý
                    char b = (char)x; // Ký tự taạ vị trí a[i]
                    s += b; // thêm vào chuỗi s
                }
                else
                    s += a[i];
            }
            return s;
        }
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = s.Length;
            s = lowerCase(s);
            Dictionary<char, int> freq = new Dictionary<char, int>(24);
            for (int i = 0; i < n; i++)
            {
                if (s[i] != ' ')
                {
                    if (freq.ContainsKey(s[i])) //kiểm tra xem kí tự tai vị trí i đã tồn tại chưa
                        freq[s[i]]++; //Nếu rồi thì + thêm giá trị
                    else
                        freq.Add(s[i], 1); //Nếu chưa thì tạo thêm key s[i] giá trị value
                }
            }
            foreach (KeyValuePair<char, int> a in freq)
                Console.WriteLine(a);
        }
        
    }
}

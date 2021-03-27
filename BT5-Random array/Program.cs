using System;

namespace BT5_Random_array
{
    class Program
    {
        public const int sizeOfArray = 5;
        public const int min = 0;
        public const int max = 100;
        public const int newSize = 20;
        static void Main(string[] args)
        {
            int[] array = new int[sizeOfArray];
            Random randNum = new Random();
            int tmp = 0;
            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = randNum.Next(min, max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.Write("Hay nhap lenh ban muon");
            Console.WriteLine();
            Console.WriteLine("Tinh tong cua mang duoc tao tu dong. Nhan a hoac 1");
            Console.WriteLine("Dem so luong cac phan tu nho hon 10. Nhan b hoac 2");
            Console.WriteLine("Tao mang moi voi 20 phan tu, roi tinh tong tu phan tu thu nhat den phan tu hien tai co gia tri nho hon 19. Nhan c hoac 3");
            char c = char.Parse(Console.ReadLine());
            if (c == 'a' || c == '1')
                tmp = 1;
            else if (c == 'b' || c == '2')
                tmp = 2;
            else if (c == 'c' || c == '3')
                tmp = 3;
            switch (tmp)
            {
                case 1:
                    {
                        int sum = 0;
                        foreach (int i in array)
                        {
                            sum += i;
                        }
                        Console.WriteLine("Tong cua mang tren la: {0}", sum);
                        break;
                    }
                case 2:
                    {
                        int count = 0;
                        for (int i = 0; i < sizeOfArray; i++)
                        {
                            if (array[i] < 10)
                            {
                                count += 1;
                            }
                        }
                        Console.WriteLine("So cac gia tri nho hon 10 la: {0}", count);
                        break;
                    }
                case 3:
                    {
                        int[] a = new int[newSize];
                        int[] b = new int[newSize];
                        int temp = 0;
                        for (int i = 0; i < newSize; i++)
                        {
                            a[i] = randNum.Next(min, max);

                            Console.WriteLine("Vi tri thu {0} co gia tri", i);
                            Console.WriteLine(a[i]);
                        }
                        for (int i = 0; i < newSize; i++)
                        {
                            if (0 <= a[i] && a[i] <= 19)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    temp += a[j];
                                }
                            }
                            b[i] = temp;
                            temp = 0;
                        }
                        for (int i = 0; i < newSize; i++)
                        {
                            if (b[i] == 0)
                                Console.WriteLine("Gia tri tai vi tri {0} cua b khong thoa yeu cau",i);
                            else
                                Console.WriteLine("Gia tri cua b tai vi tri {0} la {1}", b[i], i);
                        }
                        break;
                    }
            }
        }
    }
}

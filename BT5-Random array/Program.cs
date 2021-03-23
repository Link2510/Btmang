using System;

namespace BT5_Random_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 100;

            int[] a = new int[5];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(Min, Max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Hay chon cau lenh ban muon thuc hien");
            Console.WriteLine("Tinh tong cac gia tri trong mang (nhan phim 1)");
            Console.WriteLine("Dem cac so nho hon 10 (nhan phim 2)");
            Console.WriteLine("Tao mang moi va tinh tong tu 0 den cac gia tri nho hon hoac bang 19 (nhan phim 3) ");
            Console.ReadKey();
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine("Tong cua mang tren la: {0}", sum);
            #region b Đếm các số bé hơn 10 trong mảng
            /*
             int Min = 0;
            int Max = 100;

            int[] a = new int[5];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(Min, Max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            int count=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]<10)
                {
                    count += 1;
                }
            }
            Console.WriteLine("So cac gia tri nho hon 10 la: {0}",count);*/
            #endregion
            #region c Tạo mảng B tính B[i] khi (0<=i<=19) với size là 20
            /*
            int[] a=new int[20]; 
            int[] b =new int[a.Length];
            int temp = 0;
            int Min = 0;
            int Max = 100;
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = randNum.Next(Min, Max);

                Console.WriteLine("Vi tri thu {0} co gia tri", i);
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
            for (int i = 0; i < a.Length ; i++)
             {
                if (0<=a[i]&&a[i]<=19)
                {
                    for (int j = 0; j <=i; j++)
                    {
                        temp += a[j];
                    }
                   
                }
                b[i] = temp;
                temp = 0;
            }
            for (int i = 0; i < b.Length; i++)
             {
                if(b[i]==0)
                    Console.WriteLine("Khong thoa yeu cau");
                else
                 Console.WriteLine("Gia tri cua b tai vi tri {0} la {1}",b[i],i);
             }
            */
            #endregion
        }
    }
}

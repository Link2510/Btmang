using System;

namespace BTthem17__Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table from 1 to 10");
            int[,] table = new int[10, 10];
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    table[row, column] = (row + 1) * (column + 1);
                    Console.Write("{0}*{1}={2}",row+1,column+1,table[row, column]);
                    if (column < 9)
                    {
                        Console.Write("\t");
                    }
                    else
                        Console.WriteLine();
                }
            }
        }
    }
}

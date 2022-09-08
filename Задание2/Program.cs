using System;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество строк : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите количество столбцов : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] TS = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    TS[i, j] = r.Next(-10, 10);
                    Console.Write(TS[i, j] + "[" + i + "]" + "[" + j + "]  ");

                }
                Console.WriteLine();

            }
            int q = 0;
            int max = 0;
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                p = 0;
                for (int j = 0; j < m; j++)
                {
                    if (TS[i, j] >= 0)
                    {
                        Console.WriteLine("Числа: [" + i + ";" + j + "]");
                        p++;
                    }
                    else
                    {

                    }
                }
                Console.WriteLine("Положительных элементов: " + p);
                if (p > max)
                {
                    max = p;
                    q = i;
                }
            }
            Console.WriteLine("Строка с наибольшим кол-вом положительных элементов: " + q);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (q == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(TS[i, j] + "[" + i + "]" + "[" + j + "]  ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
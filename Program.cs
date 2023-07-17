using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 52.\n Задайте двумерный массив из целых чисел.\n Найдите среднее арифметическое элементов в каждом столбце\n";

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            try
            {
                Console.Write("Input M: ");
                uint m = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Input N: ");
                uint n = Convert.ToUInt32(Console.ReadLine());

                uint[,] a = new uint[m,n];

                Random r = new Random();

                for (uint x = 0; x < m; x++)
                {
                    for (uint y = 0; y < n; y++)
                    {
                        a[x, y] = (uint) (r.Next(Int32.MinValue, Int32.MaxValue) + (uint) Int32.MaxValue);

                        Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[x, y]);
                    }

                    Console.Write("\n");
                }

                Console.WriteLine("=====================================\n");

                for (uint x = 0; x < n; x++)
                {
                    uint mean_col = 0;

                    for (uint y = 0; y < m; y++)
                    {
                        mean_col += a[y, x];

                        Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[y, x]);
                    }

                    Console.WriteLine("\n\t  >>> Среденее: {0}\n", (float) mean_col/m);
                }
            }

            catch (System.FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }

        }
    }
}
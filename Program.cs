using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 47.\n Задайте двумерный массив размером m×n,\n заполненный случайными вещественными числами\n";

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
                        a[x, y] = (uint) (r.Next(Int32.MinValue, Int32.MaxValue) + (uint)Int32.MaxValue);

                        Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[x, y]);
                    }

                    Console.WriteLine("\n");
                }
            }

            catch (System.FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }

        }
    }
}
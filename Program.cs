using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 58: \n\nЗадайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n";

        // метод для умножения матриц
        static uint[,] GetMatrix(uint num)
        {
            uint m = num;
            uint n = num;

            uint[,] a = new uint[m, n];

            Random r = new Random();

            Console.Write("\n== Input =====================\n\n");

            for (uint x = 0; x < m; x++)
            {
                for (uint y = 0; y < n; y++)
                {
                    a[x, y] = (uint)r.Next(0, 8);
                    
                    Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[x, y]);
                }

                Console.Write("\n");
            }

            return a;
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            try
            {
                Console.Write("Input matrix size: ");

                uint size = Convert.ToUInt32(Console.ReadLine());

                uint[,] a = GetMatrix(size);
                uint[,] b = GetMatrix(size);

                uint[,] r = new uint[size, size];

                for (var i = 0; i < size; i++)
                {
                    for (var j = 0; j < size; j++)
                    {
                        r[i, j] = 0;

                        for (var k = 0; k < size; k++)
                        {
                            r[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }

                Console.Write("\n== Print =====================\n\n");

                for (uint x = 0; x < size; x++)
                {
                    for (uint y = 0; y < size; y++)
                    {
                        Console.WriteLine("\tМассив r[{0},{1}] = {2}", x, y, r[x, y]);
                    }

                    Console.Write("\n");
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }
        }
    }
}
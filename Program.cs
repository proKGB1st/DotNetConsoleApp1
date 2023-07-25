using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 56: \n\nЗадайте прямоугольный двумерный массив. \nНапишите программу, которая будет находить строку с наименьшей суммой элементов.\n";

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

                Console.Write("\n== Input =====================\n\n");

                for (uint x = 0; x < m; x++)
                {
                    for (uint y = 0; y < n; y++)
                    {
                        a[x, y] = (uint) r.Next(0, 23); 
                        // a[x, y] = (uint) (r.Next(Int32.MinValue, Int32.MaxValue) + (uint) Int32.MaxValue);

                        Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[x, y]);
                    }

                    Console.Write("\n");
                }

                Console.WriteLine("== Sorting =====================\n");

                uint idx = 0;
                uint min = 0;

                for (uint x = 0; x < m; x++)
                {
                    uint sum = 0;

                    for (uint y = 0; y < n; y++)
                    {
                        sum += a[x, y];
                    }

                    if ((min == 0) || min > sum)
                    {
                        min = sum;
                        idx = x;
                    }
                }

                Console.WriteLine("\tСтрока {0} с найменьшей суммой {1}: ", idx, min);
            }

            catch (System.FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }

        }
    }
}
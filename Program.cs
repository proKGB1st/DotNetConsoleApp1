using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 50.\n Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,\n и возвращает значение этого элемента или же указание, что такого элемента нет\n";

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            try
            {
                Console.Write("Pos M: ");
                uint m = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Pos N: ");
                uint n = Convert.ToUInt32(Console.ReadLine());

                uint[,] a = new uint[3,4];

                Random r = new Random();

                for (uint x = 0; x < 3; x++)
                {
                    for (uint y = 0; y < 4; y++)
                    {
                        a[x, y] = (uint) (r.Next(Int32.MinValue, Int32.MaxValue) + (uint)Int32.MaxValue);

                        Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[x, y]);
                    }

                    Console.WriteLine("\n");
                }

                try
                {
                    Console.WriteLine("Found index value in pos {0},{1}: {0}", m, n, a[m, n]);
                }

                catch (IndexOutOfRangeException)
                {

                    throw;
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("No such index in array!\n\n");
            }
        }
    }
}
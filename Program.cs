using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 60. \nСформируйте трёхмерный массив из неповторяющихся двузначных чисел. \nНапишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\nМассив размером 2x2x2\n";

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            try
            {
                Console.Write("Input matrix size (recommended size's 2): ");

                uint size = Convert.ToUInt32(Console.ReadLine());

                uint[,,] r = new uint[size, size, size];

                Console.Write("\n== Print =====================\n\n");

                uint val = 10;

                for (uint x = 0; x < size; x++)
                {
                    val += x;

                    for (uint y = 0; y < size; y++)
                    {
                        val += y + 1;

                        for (uint z = 0; z < size; z++)
                        {
                            r[x, y, z] = val + z;

                            Console.WriteLine("\tМассив r[{0},{1},{2}] = {3}", x, y, z, r[x, y, z]);
                        }
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
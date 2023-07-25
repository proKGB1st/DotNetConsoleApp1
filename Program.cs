using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 60. \n\nСформируйте трёхмерный массив из неповторяющихся двузначных чисел. \nНапишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. \nМассив размером 2x2x2\n";

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            try
            {
                Console.Write("Input matrix size: ");

                int size = Convert.ToInt32(Console.ReadLine());

                int[,,] r = new int[size, size, size];

                int val = 10;

                for(int i = 0; i < size; i++)
                {
                    val += i;

                    for(int j = 0; j < size; j++)
                    {
                        val += j;

                        for (int k = 0; k < size; k++)
                        {
                            r[i, j, k] = val + k;
                        }
                    } 
                }

                Console.Write("\n== Print =====================\n\n");

                for (int x = 0; x < size; x++)
                {
                    for (int y = 0; y < size; y++)
                    {
                        for (int z = 0; z < size; z++)
                        {
                            Console.WriteLine("\tМассив a[{0},{1},{2}] = {3}", x, y, z, r[x, y, z]);
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
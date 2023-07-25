using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 54: Задайте двумерный массив. \nНапишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n";

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

                for (uint x = 0; x < m; x++)
                {
                    uint temp;

                    for (uint y = 0; y < n; y++)
                    {
                        for (uint z = 0; z < n; z++)
                        {
                            if (a[x,y] > a[x,z])
                            {
                                temp = a[x,y];
                                a[x,y] = a[x,z];
                                a[x,z] = temp;
                            }
                        }
                    }
                }

                for (uint x = 0; x < m; x++)
                {
                    for (uint y = 0; y < n; y++)
                    {

                        Console.WriteLine("\tМассив a[{0},{1}] = {2}", x, y, a[x, y]);
                    }

                    Console.Write("\n");
                }
            }

            catch (System.FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }

        }
    }
}
using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);

            try
            {
                System.Console.WriteLine("Input k1:");
                Int64 k1 = 0;
                k1 = System.Int64.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Input b1:");
                Int64 b1 = 0;
                b1 = System.Int64.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Input k2:");
                Int64 k2 = 0;
                k2 = System.Int64.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Input b2:");
                Int64 b2 = 0;
                b2 = System.Int64.Parse(System.Console.ReadLine());
                
                Int64 k = k1-k2;
                Int64 x = k/(b1-b2);
                Int64 y = k2*x+b2;

                System.Console.WriteLine("Cross point: ({0};{1})", x, y);
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }

        }
    }
}
using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 64. Задайте значение N.\nНапишите программу, которая выведет все натуральные числа в промежутке от N до 1.\nВыполнить с помощью рекурсии.\n";

        public static uint PrintNumbers(uint val)
        {
            if (val >= 1)
            {
                Console.Write($"{val--} ");
                PrintNumbers(val);
            }

            return 0;
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            try
            {
                Console.Write("Input value (recommended more than 1): ");
                PrintNumbers(Convert.ToUInt32(Console.ReadLine()));
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }
        }
    }
}
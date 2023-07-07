using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);
            
            int num = 0;
            int deg = 0;

            try
            {
                System.Console.WriteLine("Input your number:");
                num = (int) System.Int64.Parse(System.Console.ReadLine());

                System.Console.WriteLine("Input degree value:");
                deg = (int) System.Int64.Parse(System.Console.ReadLine());
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }

            // System.Console.WriteLine("\nYour number's: {0} -> {1}", num, deg);
            int res = num;

            for (int i = 1; i < deg; ++i)
            {
                res *= num;
            }

            System.Console.WriteLine("Result's: {0}", res);
        }
    }
}
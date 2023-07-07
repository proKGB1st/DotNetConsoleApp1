using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);
            
            int num = 0;

            try
            {
                System.Console.WriteLine("Input your number:");
                num = (int) System.Int64.Parse(System.Console.ReadLine());
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }

            int sum = 0;

            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            System.Console.WriteLine("Value: {0}", sum);
        }
    }
}
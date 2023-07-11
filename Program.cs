using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 41: Пользователь вводит с клавиатуры M чисел. \nПосчитайте, сколько чисел больше 0 ввёл пользователь.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);
            
            Int64 val = 0;
            Int64 counter = 0;

            while (true)
            {
                string input = System.Console.ReadLine();

                try
                {
                    val = System.Int64.Parse(input);

                    if (true == val > 0)
                    {
                        counter++;
                    }

                    System.Console.WriteLine("Sum of values are more than zero: {0}\n", counter);
                }

                catch(System.FormatException ex)
                {
                    System.Console.WriteLine("\nFormat error ocorrupted.");
                    break;
                }
            }
        }
    }
}
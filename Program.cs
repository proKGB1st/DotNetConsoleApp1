using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 23. Напишите программу,\n которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.\n";

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

            System.Console.Write("\nYour number's: {0} -> ", num);

            int count = 0;

            while ((bool) (count != num))
            {
                int val = (int) Math.Pow(++count, 3);
                System.Console.Write("{0}{1}", (count != 1 ? ", " : ""), val);
            }
        }
    }
}
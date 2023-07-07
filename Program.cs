using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);

            Random rg = new Random();
            
            int[] arr = new int[rg.Next(0, 64)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rg.Next(0, 999);
            }

            int counter = 0;

            foreach (int val in arr)
            {
                if (0 == val%2)
                {
                    counter++;
                }
            }

            System.Console.Write("{0} ", counter);
        }
    }
}
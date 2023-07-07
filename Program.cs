using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\n";

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

            int sum = 0;

            foreach (int val in arr)
            {
                if (0 != val%2)
                {
                    sum += val;
                }
            }

            System.Console.Write("Sum: {0} ", sum);
        }
    }
}
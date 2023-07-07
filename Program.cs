using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);
            
            int[] arr = new int[8];

            foreach (int val in arr)
            {
                System.Console.Write("{0}", val);
            }
        }
    }
}
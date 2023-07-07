using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\n";
        
        static float NextFloat(Random rand)
        {
            double val = rand.NextDouble();
            val -= 0.5;
            val *= 2;
            return float.MaxValue * (float) val;
        }
        
        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);

            Random rg = new Random();
            
            double[] arr = new double[rg.Next(0, 64)];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = NextFloat(rg);
            }

            System.Console.Write("Min: {0}, Max: {1} => {2}", arr.Min(), arr.Max(), (arr.Max() - arr.Min()));
        }
    }
}
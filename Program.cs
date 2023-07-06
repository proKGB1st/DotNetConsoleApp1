using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 21. Напишите программу, \nкоторая принимает на вход координаты двух точек \nи находит расстояние между ними в 3D пространстве.\n";

        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);
            
            int count = 0;
            int point = 0;

            int[,] Points = new int[2,3];

            while ((bool) (count != -1))
            {
                try
                {
                    System.Console.WriteLine("Input your {0} number for your {1} point", count+1, point+1);
                    Points[point, count] = (int) System.Int64.Parse(System.Console.ReadLine());

                    if (++count > 2)
                    {
                        count = 0;
                        if ((bool) (++point > 1))
                        {
                            count = -1;
                        }
                    }
                }

                catch(System.FormatException ex)
                {
                    System.Console.WriteLine("Format error ocorrupted.");
                }
            }

            // Заранее можно было бы посчитать в цикле, если выводить запрос на числа
            // для первой и второй точки последовательно, а не по порядку..
            
            int rx = Points[1,0] - Points[0,0];
            int ry = Points[1,1] - Points[0,1];
            int rz = Points[1,2] - Points[0,2];

            System.Console.WriteLine("The distance between two vectors is: {0}", Math.Sqrt(Math.Pow(rx, 2) + Math.Pow(ry, 2) + Math.Pow(rz, 2)));
        }
    }
}
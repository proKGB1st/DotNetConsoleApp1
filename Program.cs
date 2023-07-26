using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 68.\nНапишите программу вычисления функции Аккермана с помощью рекурсии.\nДаны два неотрицательных числа m и n.\n";

        // Описание алгоритма вычислительной функции Аккермана:
        // https://ru.wikipedia.org/wiki/Функция_Аккермана#Реализация

        public static uint Akkerman(uint m, uint n)
        {
            if (m == 0)
            {
                return n + 1;
            } 

            else if (n == 0)
            {
                return Akkerman(m-1, 1);
            }

            else
            {
                return Akkerman(m-1, Akkerman(m, n-1));
            }

            return 0;
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);
            
            uint m = 0;
            uint n = 0;

            try
            {
                Console.Write("Input M value: ");
                m = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Input N value: ");
                n = Convert.ToUInt32(Console.ReadLine());
                
                uint akk_res = Akkerman(m, n);
                Console.Write($"The numbers in: {m} and {n}. Akkerman result: {akk_res}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }
        }
    }
}
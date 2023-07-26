using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 66.\nЗадайте значения M и N.\nНапишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\n";

        public static uint PrintNumbers(uint c, uint m, uint n)
        {
            if (n > c)
            {
                m += n--;
                m = PrintNumbers(c, m, n);
            }

            return m;
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

                if (m > n)
                {
                    uint t = m;

                    n = m;
                    m = t;
                }

                uint sum = PrintNumbers(m, m, n);
                Console.Write($"The numbers in: {m} and {n}. Sum's: {sum}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }
        }
    }
}
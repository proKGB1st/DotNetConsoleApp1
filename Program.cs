using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "Задача 62. \nНапишите программу, которая заполнит спирально массив 4x4.\n";

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);

            int size = 4;

            int[,] r = new int[size, size];
            
            int len = (int)Math.Pow(size, 2);

            int count = 0;

            // Заполнили самую первый элемент массива
            for (int j = 0; j < size; j++)
            {
                r[0, j] = ++count;
            }

            // Реализация алгоритма Улитка"
            // Источник: https://mob25.com/zapolnenie-matricy-po-spirali-v-python/

            // Наблюдаемый последний элемент
            int latest = 0;

            // Рабочая ячейка
            int i = size-1;

            // Размер витка
            --size;

            // Рекурсивный-реверсивный алгоритм
            // 
            // Учитывая, что первая строка заполняется слева-направо,
            // постепенное движение будет происходить по следующему статическому алгоритму (→ ↓ ← ↑)

            while (len != count)
            {
                // ↓
                for (int j = 0; j < size; ++j)
                    r[++latest, i] = ++count;

                // ←
                for (int j = 0; j < size; ++j)
                    r[latest, --i] = ++count;

                // ↑
                for (int j = 0; j < size-1; ++j)
                    r[--latest, i] = ++count;

                // →
                for (int j = 0; j < size-1; ++j)
                    r[latest, ++i] = ++count;

                // Переходим на внутренний виток
                size -= 2;
            }

            Console.Write("== Print =====================\n\n");

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    int val = r[x, y];

                    Console.Write("{0} {1}", (val <= 9 ? " " : ""), val);
                }

                Console.Write("\n");
            }
        }
    }
}
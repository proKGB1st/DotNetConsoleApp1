using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine("Input your number (from 1 to 7):");

            byte mask = 0x7C;

            try
            {
                Int16 input_value = System.Int16.Parse(System.Console.ReadLine());

                if (input_value > 7 || input_value < 1)
                {
                    System.Console.WriteLine("Format error ocorrupted.");
                    return;
                }
                
                System.Console.WriteLine("Is holiday? {0}", (((mask >> (input_value - 1)) & mask) != 0x0 ? "False" : "True"));
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }
        }
    }
}
using System;

namespace DotNetConsoleApp1
{
    class Program
    {
        public static string Task = "\n";
        
        public static uint PublicMethod(uint m, uint n)
        {
            return 0;
        }

        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(Task);
            
            uint m = 0;

            try
            {
                Console.Write("Input M value: ");
                m = Convert.ToUInt32(Console.ReadLine());
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Format error occorupted!\n\n");
            }
        }
    }
}
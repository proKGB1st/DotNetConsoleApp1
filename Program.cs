using System;

namespace DotNetConsoleApp1
{
    class MainApp
    {
        private Int64 input_number;
        private Int64 digit_size = 0;
        private uint digit_value;

        public MainApp(string? input)
        {
            try
            {
                this.input_number = System.Int64.Parse(input == null ? "" : input);
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }

            System.Console.Clear();
            this.GetInputDigit(this.input_number);
        }

        private void GetInputDigit(Int64 num)
        {
            if (num > 0)
            {
                num /= 10;
                ++this.digit_size;

                if (this.digit_size == 1)
                {
                    //System.Console.WriteLine("Digit size from {0} is {1} on value {2}/{3}", this.input_number, this.digit_size, num, ((num%10)%10));
                    System.Console.WriteLine("The second digit value {0}", ((num%10)%10));
                    return;
                }

                GetInputDigit(num);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine("Input your number (3 digits format):");
            new MainApp(System.Console.ReadLine());
            System.Console.WriteLine();
        }
    }
}
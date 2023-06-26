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

                if (this.input_number != this.input_number%100)
                {
                    this.GetInputDigit(this.ReverseNumber(this.input_number));
                }

                else
                {
                    System.Console.WriteLine("Input number {0} has an incorrect format (needed at least to be more or equal 3 digits)", this.input_number);
                }
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }
        }

        private Int64 ReverseNumber(Int64 num)
        {
            Int64 reversed = 0;
            while (num > 0)
            {
                reversed *= 10;
                reversed += num % 10;
                num /= 10;
            }
            return reversed;
        }

        private void GetInputDigit(Int64 num)
        {
            if ((num /= 10) > 0)
            {
                if (2 == ++this.digit_size)
                {       
                    System.Console.WriteLine("The second digit value {0}", num%10);
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
            System.Console.WriteLine("Input your number (anyway digits format/no zero beginning):");
            new MainApp(System.Console.ReadLine());
            System.Console.WriteLine();
        }
    }
}
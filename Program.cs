using System;

namespace DotNetConsoleApp1
{
    class MainApp
    {
        private Int64 input_number;
        private Int64 reversed_number;
        private Int64 digit_size = 0;

        public MainApp(string? input)
        {
            try
            {
                this.input_number = System.Int64.Parse(input == null ? "" : input);

                this.GetInputDigit(this.input_number);
                
                if (5 <= this.digit_size)
                {
                    this.ReverseNumber(this.input_number);

                    System.Console.WriteLine(
                        "Input number{0} palindrome!", 
                        this.reversed_number == this.input_number ? "'s" : " isn't "
                    );
                }
                
                else
                {
                    System.Console.WriteLine(
                        "Input number {0} has an incorrect format (needed at least to be more or equal 5 digits)", 
                        this.input_number
                    );
                }
            }

            catch(System.FormatException ex)
            {
                System.Console.WriteLine("Format error ocorrupted.");
            }
        }

        private void ReverseNumber(Int64 num)
        {
            this.reversed_number = 0;
            
            while (num > 0)
            {
                this.reversed_number *= 10;
                this.reversed_number += num % 10;
                num /= 10;
            }
        }

        private void GetInputDigit(Int64 num)
        {
            if ((num /= 10) > 0)
            {
                ++this.digit_size;
                GetInputDigit(num);
            }

            else if (this.input_number % 10 > 0)
            {
                ++this.digit_size;
            }
        }
    }

    class Program
    {
        public static string Task = "Напишите программу, \nкоторая принимает на вход пятизначное число и проверяет, \nявляется ли оно палиндромом.\n";
        
        public static void Main(string[] args)
        {
            System.Console.Clear();
            System.Console.WriteLine(Task);
            System.Console.WriteLine("Input your number (anyway digits format/no zero beginning):");
            new MainApp(System.Console.ReadLine());
            System.Console.WriteLine();
        }
    }
}
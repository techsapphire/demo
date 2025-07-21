using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator - Addition and Subtraction");

            try
            {
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter '+' for addition or '-' for subtraction: ");
                string? op = Console.ReadLine();

                double result = op switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    _ => throw new InvalidOperationException("Invalid operation")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

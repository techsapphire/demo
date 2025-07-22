using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator - Addition and Subtraction");

            while (true)
            {
                Console.Write("Enter '+' for addition, '-' for subtraction, or 'q' to quit: ");
                string? op = Console.ReadLine();

                if (string.Equals(op, "q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    Console.Write("Enter the first number: ");
                    double num1 = double.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Enter the second number: ");
                    double num2 = double.Parse(Console.ReadLine() ?? "0");

                    double result = op switch
                    {
                        "+" => num1 + num2,
                        "-" => num1 - num2,
                        _ => double.NaN
                    };

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Invalid operation\n");
                        continue;
                    }

                    Console.WriteLine($"Result: {result}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }
    }
}

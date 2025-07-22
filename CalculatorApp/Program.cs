using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
// <<<<<<< 3gd8mh-codex/add-addition-and-subtraction-features
            Console.WriteLine("Simple Calculator - Add, Subtract, Multiply, Divide");

            while (true)
            {
                Console.Write("Enter '+' for addition, '-' for subtraction, '*' for multiplication, '/' for division, or 'q' to quit: ");
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
                        "*" => num1 * num2,
                        "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
                        _ => throw new InvalidOperationException("Invalid operation")
                    };

                    Console.WriteLine($"Result: {result}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }

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
       main
            }
        }
    }
}

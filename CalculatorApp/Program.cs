using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator - Add, Subtract, Multiply, Divide, BMI");

            while (true)
            {
                Console.WriteLine("Enter an operation:");
                Console.WriteLine("  '+' for addition");
                Console.WriteLine("  '-' for subtraction");
                Console.WriteLine("  '*' for multiplication");
                Console.WriteLine("  '/' for division");
                Console.WriteLine("  'b' for BMI calculation");
                Console.WriteLine("  'q' to quit");
                Console.Write("Choice: ");
                string? op = Console.ReadLine();

                if (string.Equals(op, "q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    if (op == "b" || op == "B")
                    {
                        Console.Write("Enter your weight in kilograms: ");
                        double weight = double.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Enter your height in meters: ");
                        double height = double.Parse(Console.ReadLine() ?? "0");

                        if (height != 0)
                        {
                            double bmi = weight / (height * height);
                            Console.WriteLine($"BMI: {bmi:F2}\n");
                        }
                        else
                        {
                            Console.WriteLine("Invalid height\n");
                        }
                    }
                    else
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }
    }
}

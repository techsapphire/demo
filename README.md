# Calculator App

This repository contains a simple .NET console application that performs basic math operations and BMI calculation.

## Features
- Addition, subtraction, multiplication, and division
- BMI calculation (weight in kilograms and height in meters)
- Interactive prompt that repeats until you choose to quit

## Building and Running
1. Ensure that the .NET 8 SDK is installed. If needed, run the provided script:
   ```bash
   ./dotnet-install.sh --version 8.0.100 --install-dir "$HOME/.dotnet"
   export DOTNET_ROOT="$HOME/.dotnet"
   export PATH="$PATH:$HOME/.dotnet"
   ```
2. Build the application:
   ```bash
   dotnet build CalculatorApp/CalculatorApp.csproj --configuration Release
   ```
3. Run the application:
   ```bash
   dotnet run --project CalculatorApp
   ```

Example session:

```
Simple Calculator - Add, Subtract, Multiply, Divide, BMI
Enter an operation:
  '+' for addition
  '-' for subtraction
  '*' for multiplication
  '/' for division
  'b' for BMI calculation
  'q' to quit
Choice: +
Enter the first number: 5
Enter the second number: 3
Result: 8

Enter an operation:
  '+' for addition
  '-' for subtraction
  '*' for multiplication
  '/' for division
  'b' for BMI calculation
  'q' to quit
Choice: b
Enter your weight in kilograms: 70
Enter your height in meters: 1.75
BMI: 22.86

Enter an operation:
  '+' for addition
  '-' for subtraction
  '*' for multiplication
  '/' for division
  'b' for BMI calculation
  'q' to quit
Choice: q
```

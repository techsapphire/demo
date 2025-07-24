# Calculator App

This repository contains a simple .NET console application that performs basic addition, subtraction, and BMI calculation.

## Features
- Addition and subtraction
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
Simple Calculator - Addition and Subtraction
Enter 'b' to calculate BMI.
Enter '+' for addition, '-' for subtraction, or 'q' to quit: +
Enter the first number: 5
Enter the second number: 3
Result: 8

Enter 'b' to calculate BMI.
Enter '+' for addition, '-' for subtraction, or 'q' to quit: b
Enter the first number: 70
Enter the second number: 1.75
BMI: 22.86

Enter 'b' to calculate BMI.
Enter '+' for addition, '-' for subtraction, or 'q' to quit: q
```

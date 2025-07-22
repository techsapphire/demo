# Calculator App

This repository contains a simple .NET console application that performs basic arithmetic operations.

## Features
- Addition, subtraction, multiplication, and division
- Interactive prompt that repeats until you choose to quit

## Building and Running
1. Ensure that the .NET 8 SDK is installed (the repository includes a helper script `dotnet-install.sh`).
2. Build the application:
   ```bash
   dotnet build CalculatorApp/CalculatorApp.csproj --configuration Release
   ```
3. Run the application:
   ```bash
   dotnet run --project CalculatorApp
   ```

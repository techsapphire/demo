# Calculator App

This repository contains a simple .NET console application that performs basic addition and subtraction.

## Features
- Addition and subtraction
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

// See https://aka.ms/new-console-template for more information
using CalculatorApp;

var Calc = new Calculator();


Console.WriteLine("=== Calculator App ===");
Console.WriteLine($"5 + 4 = {Calc.Add(5, 4)}");
Console.WriteLine($"10 - 3 = {Calc.Subtract(10, 3)}");
Console.WriteLine($"5 * 4 = {Calc.Multiply(5, 4)}");
Console.WriteLine($"10 / 2 = {Calc.Divide(10, 2)}");
Console.WriteLine($"7 / 2 = {Calc.Divide(7, 2)}");

// Test divide by zero error handling
try
{
    Console.WriteLine($"10 / 0 = {Calc.Divide(10, 0)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
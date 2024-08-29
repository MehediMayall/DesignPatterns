namespace ResultPattern;

public sealed record CalculatorErrors
{
    public static Error DivideByZero() => 
        new Error("Calculator.Error", "Trying to divide by zero value.");
}
using ResultPattern;
using static System.Console;


Result<int> Divide(int x, int y)
{
    if (y == 0)
        return Result.Failure<int>(CalculatorErrors.DivideByZero());

    // return Result.Success(x / y);
    return x / y;
}




Result DivideAndPrint(int x, int y)
{
    if (y == 0)
        return Result.Failure<int>(CalculatorErrors.DivideByZero());

    WriteLine(x / y);
    return Result.Success();
}

int num1 = 19;
int num2 = 10;


var result = Divide(num1, num2);
if (result.IsSuccess) 
    WriteLine(result.Value);
else
    WriteLine(result.Error.Detail);


var result2 = DivideAndPrint(num1, num2);
if (result2.IsSuccess)
    WriteLine("Successfully printed");
else
    WriteLine(result2.Error.Detail);
namespace ResultPattern;


// Non Generic Result used by default and has no return value
public class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }

    public static Result Success() => new Result(true, Error.None);
    public static Result Failure(Error error) => new Result(false, error);

    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);
    public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);

}


// Generic Result when need to return value
public class Result<TValue>: Result
{
    private readonly TValue? _Value;

    protected internal Result(TValue? Value, bool IsSuccess, Error error): base(IsSuccess, error)
    {
        _Value = Value;
    }

    public TValue Value => IsSuccess ?
        _Value!
        : throw new Exception("The value of failure result can't be accessed");

    public static implicit operator Result<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failure<TValue>(Error.NullValue);

}
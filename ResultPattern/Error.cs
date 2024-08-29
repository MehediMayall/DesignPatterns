namespace ResultPattern;

public sealed record Error(string Code, string Detail)
{
    public static Error None => new(string.Empty, string.Empty);
    public static Error NullValue => new("NullValue","Found null value");
}
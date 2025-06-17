namespace DecoratorPattern;

public class PlainPizza : IPizza
{
    public string GetDescription() => "Plain Pizza";
    public decimal GetPrice() => 200.0M;
}
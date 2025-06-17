namespace DecoratorPattern;

public class CheeseDecorator : PizzaDecorator
{
    public CheeseDecorator(IPizza pizza) : base(pizza) { }

    public override string GetDescription() =>
        base.GetDescription() + ", with cheese";

    public override decimal GetPrice() =>
        base.GetPrice() + 150.0M;
}
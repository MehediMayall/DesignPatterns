namespace DecoratorPattern;

public class PepperoniDecorator : PizzaDecorator
{
    public PepperoniDecorator(IPizza pizza) : base(pizza) { }

    public override string GetDescription() =>
        base.GetDescription() + ", with pepperoni";

    public override decimal GetPrice() =>
        base.GetPrice() + 75.0M;
}
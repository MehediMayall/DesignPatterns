namespace DecoratorPattern;

public abstract class PizzaDecorator : IPizza
{
    protected IPizza _pizza;
    public PizzaDecorator(IPizza pizza) => _pizza = pizza;

    public virtual string GetDescription() =>
        _pizza.GetDescription();

    public virtual decimal GetPrice() =>
        _pizza.GetPrice();
}


using static System.Console;
using DecoratorPattern;


// Plain Pizza
IPizza plainPizza = new PlainPizza();
WriteLine($"{plainPizza.GetDescription()}, Price: {plainPizza.GetPrice()}");


// Plain Pizza with cheese
IPizza cheesePizza = new CheeseDecorator(plainPizza);
WriteLine($"{cheesePizza.GetDescription()}, Price: {cheesePizza.GetPrice()}");

// Pepperoni Pizza with cheese
IPizza pepperoniPizza = new PepperoniDecorator(cheesePizza);
WriteLine($"{pepperoniPizza.GetDescription()}, Price: {pepperoniPizza.GetPrice()}");


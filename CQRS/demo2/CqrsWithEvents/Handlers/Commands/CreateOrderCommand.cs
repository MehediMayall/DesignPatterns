namespace CqrsWithEvents;

public class CreateOrderCommand(Order order) : ICommand
{
    public Order Order { get; } = order;
}
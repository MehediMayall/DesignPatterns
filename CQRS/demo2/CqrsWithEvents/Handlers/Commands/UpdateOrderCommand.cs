namespace CqrsWithEvents;

public class UpdateOrderCommand(Order order) : ICommand
{
    public Order Order { get; } = order;
}
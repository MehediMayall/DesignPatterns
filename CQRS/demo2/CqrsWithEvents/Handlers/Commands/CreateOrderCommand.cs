namespace CqrsWithEvents;

public class CreateOrderCommand(OrderForCreateDto order) : ICommand
{
    public OrderForCreateDto Order { get; } = order;
}
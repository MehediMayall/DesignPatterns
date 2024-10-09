namespace CqrsWithEvents;

public class GetOrderByIdQuery(Guid Id) : IQuery
{
    public Guid Id { get; } = Id;
}
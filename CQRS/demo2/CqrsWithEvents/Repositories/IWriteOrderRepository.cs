namespace CqrsWithEvents;

public interface IWriteOrderRepository {
    Task CreateOrder(Order order);
    Task UpdateOrder(Order order);
    Task<bool> DeleteOrder(Guid orderId);
}
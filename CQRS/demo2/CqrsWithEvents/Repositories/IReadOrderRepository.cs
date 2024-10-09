namespace CqrsWithEvents;

public interface IReadOrderRepository{
    Task<Order?> GetOrderById(Guid orderId);
    Task<List<Order>> GetOrders();
}
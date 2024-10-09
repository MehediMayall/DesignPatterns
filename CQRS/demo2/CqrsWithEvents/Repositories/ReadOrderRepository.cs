
namespace CqrsWithEvents;

public class ReadOrderRepository : IReadOrderRepository
{
    public Task<Order> GetOrderById(Guid orderId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Order>> GetOrders()
    {
        throw new NotImplementedException();
    }
}
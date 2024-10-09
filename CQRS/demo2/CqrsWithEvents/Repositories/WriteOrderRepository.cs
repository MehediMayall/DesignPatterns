
namespace CqrsWithEvents;


public class WriteOrderRepository : IWriteOrderRepository
{
    public Task CreateOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteOrder(Guid orderId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrder(Order order)
    {
        throw new NotImplementedException();
    }
}
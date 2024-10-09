
namespace CqrsWithEvents;


public class WriteOrderRepository : IWriteOrderRepository
{
    private readonly AppDbContext db;

    public WriteOrderRepository(AppDbContext db)
    {
        this.db = db;
    }
    public async Task CreateOrder(Order order){
        db.Orders.Add(order);
        await db.SaveChangesAsync();
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
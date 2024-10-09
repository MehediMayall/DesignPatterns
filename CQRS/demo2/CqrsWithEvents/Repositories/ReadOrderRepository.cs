
using Microsoft.EntityFrameworkCore;

namespace CqrsWithEvents;

public class ReadOrderRepository : IReadOrderRepository
{
    private readonly AppDbContext db;

    public ReadOrderRepository(AppDbContext db)
    {
        this.db = db;
    }
    public async Task<Order?> GetOrderById(Guid orderId) =>
        await db.Orders.FirstOrDefaultAsync(order => order.Id == orderId) ?? default;
    

    public async Task<List<Order>> GetOrders() =>
        await db.Orders.ToListAsync();
    
}
namespace CqrsWithEvents;

public class GetOrdersQueryHandler(IReadOrderRepository repo): IQueryHandler<GetOrdersQuery,List<Order>> {
    public IReadOrderRepository Repo { get; } = repo;

    public async Task<List<Order>> Handle(GetOrdersQuery query) {
        return await Repo.GetOrders();
    }
}
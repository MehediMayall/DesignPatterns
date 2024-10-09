namespace CqrsWithEvents;

public class GetOrderByIdQueryHandler(IReadOrderRepository repo): IQueryHandler<GetOrderByIdQuery, Order>{
    public IReadOrderRepository Repo { get; } = repo;

    public async Task<Order> Handle(GetOrderByIdQuery query) {
        return await Repo.GetOrderById(query.Id);
    }
}
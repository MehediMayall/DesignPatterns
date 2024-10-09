using AutoMapper;

namespace CqrsWithEvents;

public class CreateOrderCommandHandler(IWriteOrderRepository repo, IMapper mapper) : ICommandHandler<CreateOrderCommand>{
    private readonly IMapper mapper = mapper;

    public IWriteOrderRepository Repo { get; } = repo;

    public async Task Handle(CreateOrderCommand command) {
        var order =  mapper.Map<Order>(command.Order);
        order.Id = Guid.NewGuid();
        await Repo.CreateOrder(order);
    }
}
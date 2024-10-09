namespace CqrsWithEvents;

public class CreateOrderCommandHandler(IWriteOrderRepository repo) : ICommandHandler<CreateOrderCommand>{
    public IWriteOrderRepository Repo { get; } = repo;

    public async Task Handle(CreateOrderCommand command) {
        await Repo.CreateOrder(command.Order);
    }
}
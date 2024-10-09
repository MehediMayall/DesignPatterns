namespace CqrsWithEvents;

public class UpdateOrderCommandHandler(IWriteOrderRepository repo) : ICommandHandler<UpdateOrderCommand>{
    public IWriteOrderRepository Repo { get; } = repo;

    public async Task Handle(UpdateOrderCommand command) {
        await Repo.UpdateOrder(command.Order);
    }
}
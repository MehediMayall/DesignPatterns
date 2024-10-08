using Domain;

namespace Application;

public sealed record StartFollowingCommand(Guid UserId, Guid FollowedId): ICommand{}

public sealed class StartFollowingCommandHandler : ICommandHandler<StartFollowingCommand> {
    private readonly IUserRepository userRepo;

    public StartFollowingCommandHandler(IUserRepository userRepo)
    {
        this.userRepo = userRepo;
    }

    public async Task<Result> Handle(StartFollowingCommand command, CancellationToken cancellationToken = default) {

        User? user = await userRepo.GetByIdAsync(command.FollowedId, cancellationToken);
        if (user is null) {
            // return UserErrors.NotFound(command.FollowedId);
        }

        return new Result();
    }
}


public interface IUserRepository {
    Task<User?> GetByIdAsync(Guid Id, CancellationToken cancellationToken);
}

public static class UserErrors {
    public static Error NotFound(Guid userId) => new("Users.NotFound",$"The user with the Id={userId} not found");
}

public  class Error {
    public Error(string code, string message)
    {
        
    }
}
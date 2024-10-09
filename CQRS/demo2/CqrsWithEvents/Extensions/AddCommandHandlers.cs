namespace CqrsWithEvents;

public static class Extensions{

    public static IServiceCollection AddCommandHandlers(this IServiceCollection services, Type typeAssembly) {
        if ( typeAssembly is null ) 
            throw new ArgumentNullException(nameof(typeAssembly));

        var assembly = typeAssembly.Assembly;
        return services;
    }
}
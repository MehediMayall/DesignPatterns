using System.Reflection;

namespace CqrsWithEvents;

public static class Extensions{

    public static IServiceCollection AddCommandHandlers(this IServiceCollection services, Type typeAssembly) {
        if ( typeAssembly is null ) 
            throw new ArgumentNullException(nameof(typeAssembly));

        var assembly = typeAssembly.Assembly;
        var scanType = typeof(ICommandHandler<>);
        
        RegisterScanTypeWithImplementations(services, assembly, scanType);

        return services;
    }
    public static IServiceCollection AddQueryHandlers(this IServiceCollection services, Type typeAssembly) {
        if ( typeAssembly is null ) 
            throw new ArgumentNullException(nameof(typeAssembly));

        var assembly = typeAssembly.Assembly;
        var scanType = typeof(IQueryHandler<,>);
        
        RegisterScanTypeWithImplementations(services, assembly, scanType);

        return services;
    }

    private static void RegisterScanTypeWithImplementations(IServiceCollection services, Assembly assembly, Type scanType){
        var commandHandlers = ScanTypes(assembly, scanType);

        foreach(var handler in commandHandlers) {
            var abstraction = handler.GetTypeInfo().ImplementedInterfaces.First(
                type => type.IsGenericType && type.GetGenericTypeDefinition() == scanType);

            services.AddScoped(abstraction, handler);
        }
    }

    private static IEnumerable<Type> ScanTypes(Assembly assembly, Type scanType) {
        return assembly.GetTypes()
            .Where(
                type => type is {IsClass : true, IsAbstract: false} 
            && type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == scanType)
        );
    }


}
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace CqrsWithEvents;

public static class OrdersEndpoints{

    public static IEndpointRouteBuilder AddOrdersEndpoints(this IEndpointRouteBuilder app) {

        app.MapGet("/orders/{orderid:guid}", 
            async (Guid orderid, [FromServices] IQueryHandler<GetOrderByIdQuery, Order> handler) =>{
                var result = await handler.Handle(new GetOrderByIdQuery(orderid));
                return result is null ? Results.NoContent() : Results.Ok(result);
        });

        app.MapGet("/orders", async (IReadOrderRepository repo) =>{
            var result = await new GetOrdersQueryHandler(repo).Handle(new GetOrdersQuery());
            return result is null ? Results.NoContent() : Results.Ok(result);
        });

        app.MapPost("/orders", async (OrderForCreateDto order, IWriteOrderRepository repo, IMapper mapper) =>{
            await new CreateOrderCommandHandler(repo, mapper).Handle(new CreateOrderCommand(order));
            return Results.Ok();
        });

        return app;
    }
}
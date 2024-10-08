namespace MinimalApiCqrs;

public static class Books {

    public static void AddBooksEndpoints(this IEndpointRouteBuilder app) {

        app.MapGet("books", (BookReadRepository repo) =>{
            return Results.Ok(repo.Get());
        });

        app.MapGet("books/{id}", (Guid id, BookReadRepository repo) =>{
            return Results.Ok(repo.GetById(id));
        });

        app.MapPost("books", (Book book, BookWriteRepository repo) =>{
            book.Id = Guid.NewGuid();
            repo.Add(book);
            return Results.Ok();
        });

        app.MapPut("books", (Book book, BookWriteRepository repo) =>{
            repo.Update(book);
            return Results.NoContent();
        });

        app.MapDelete("books/{id}", (Guid id, BookWriteRepository repo) =>{
            repo.Delete(id);
            return Results.NoContent();
        });        

    }
}
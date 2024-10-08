namespace MinimalApiCqrs;

public  class InMemoryBookRepository{
    public static readonly Dictionary<Guid, Book> Books = new();

}
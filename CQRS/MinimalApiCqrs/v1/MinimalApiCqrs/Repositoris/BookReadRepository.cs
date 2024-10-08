namespace MinimalApiCqrs;

public  class BookReadRepository{

    public List<Book> Get() =>
        InMemoryBookRepository.Books.Values.ToList();

    public Book? GetById(Guid Id) =>
        InMemoryBookRepository.Books.TryGetValue(Id, out var book) ? book : default;

}
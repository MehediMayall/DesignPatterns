namespace MinimalApiCqrs;

public class BookWriteRepository{

    public void Add(Book book) =>
        InMemoryBookRepository.Books.Add(book.Id, book);

    public void Update(Book book){
        if ( !InMemoryBookRepository.Books.TryGetValue(book.Id, out var existingBook) )
            return;

        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.NumberOfPages = book.NumberOfPages;        
    } 

    public void Delete(Guid id) =>
        InMemoryBookRepository.Books.Remove(id);
}
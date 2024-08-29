namespace IteratorPattern;

// Aggregate
public interface IEmployeeCollection
{
    int Count { get; }
    Employee this[int index] {get;}
    void add(Employee employee);

    IIterator GetIterator();
}

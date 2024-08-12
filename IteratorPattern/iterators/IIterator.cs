namespace IteratorPattern;

// Abstract Iterator
public interface IIterator
{
    bool MoveNext();
    Employee GetCurrent();
    void Reset();
}

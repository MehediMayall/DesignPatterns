namespace IteratorPattern;


// Concrete Iterator
public class Iterator(EmployeeCollection employees) : IIterator
{
    private int currentIndex = -1;

    public Employee GetCurrent() =>
        employees[currentIndex];


    public bool MoveNext()
    {
        currentIndex ++;
        return currentIndex < employees.Count;
    } 

    public void Reset() =>
        currentIndex = -1;
}

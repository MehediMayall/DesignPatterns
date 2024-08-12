namespace IteratorPattern;

// Concrete Aggregate
public class EmployeeCollection : IEmployeeCollection
{
    private List<Employee> employees;
    public EmployeeCollection() => 
    employees = new List<Employee>();
    
    public void add(Employee employee) =>
        employees.Add(employee);

    public int Count => employees.Count();
    
    public Employee this[int index] => 
        employees[index];

    public IIterator GetIterator() =>
        new Iterator(this);

}

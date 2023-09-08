

namespace LazyLoading;

public class Department
{
    public int Id { get; set; }
    public string DepartmentCode { get; set; }
    public string DepartmentName { get; set; }


    private List<Employee> employees = null!;
    public List<Employee> Employees 
    { 
        get
        {
            if(employees == null) employees = getEmployees(); // On Demand Loading
            return employees;
        }
    }


    private List<Employee> getEmployees()
    {
        System.Console.WriteLine("Loading Employee Data");
        return new List<Employee>
        {
            new Employee { Id= 1, EmployeeCode= "E1", FirstName = "Mehedi", LastName = "Hasan", Email = "Mehedi@gmail.com"},
            new Employee { Id= 2, EmployeeCode= "E2", FirstName = "MehediABC", LastName = "Hasan", Email = "Mehediabc@gmail.com"},
            new Employee { Id= 3, EmployeeCode= "E3", FirstName = "MehediXYZ", LastName = "Hasan", Email = "Mehedixyz@gmail.com"},
        };
    }
   
}
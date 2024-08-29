using IteratorPattern;
using static System.Console;


// Client
EmployeeCollection employees = new();

employees.add(new Employee("Mehedi","Hasan", "IT"));
employees.add(new Employee("Ben","Kally", "Recruitment"));
employees.add(new Employee("Merceil","Roe", "Recruitment"));

var iterator = employees.GetIterator();

while (iterator.MoveNext())
{
    Employee emp = iterator.GetCurrent();
    WriteLine($"Name: {emp.FirstName} {emp.LastName}, Department: {emp.Department}");
}
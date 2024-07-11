/*
S - Single Responsibility Principle
O - Open-Closed Principle
L - Liskov Substitution Principle
I - Interface Segregation Principle
D - Dependency Inversion Principle
*/

// Liskov Substitution - Subclasses should be substitutable by their base class

using LiskovSubstitutionPrinciple;
using static System.Console;

List<IEmployee>  employees = new List<IEmployee>(); // Base Interface

employees.AddRange([
    new PermanetEmployee(1,"Mehedi Hasan"),     // Subclass type 1
    new ContractEmployee(2,"Jamil Ahmed"),      // subclass type 2
    new TemporaryEmployee(3,"Reyhan"),          // subclass type 3
]);

foreach(var employee in employees)
{
    WriteLine(employee);    
}



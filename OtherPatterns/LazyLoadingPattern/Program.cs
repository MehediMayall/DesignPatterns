/*
Lazy Loading is software design pattern where the initialization of an object occurs only when 
it is actually needed and not before to preserve simplicity of usage and improve performance.


Lazy Loading is essential when the cost of object creation is very high and the use of the object
is very rare. The fundamental idea of lazy loading is to load object/data when needed.


There are four common implementations of lazy loading pattern.

> Virtual Proxy
> Lazy Initialization
> Ghost
> Value Holder

*/


using LazyLoading;


var departmentIT = new Department{ Id = 1, DepartmentCode = "D1", DepartmentName = "Information Technology" };

Console.WriteLine(departmentIT.DepartmentName);

System.Console.WriteLine("Before counting employee number.");
var numberOfEmployees = departmentIT.Employees.Count;
Console.WriteLine(numberOfEmployees.ToString());


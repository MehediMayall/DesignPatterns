using SchoolHR.Domain;

using static System.Console;



//void SeedData(List<IEmployee> employees)
//{
//    IEmployee teacher = new Teacher
//    {
//        Id = 1,
//        FirstName = "Teacher",
//        LastName = "X",
//        Salary = 40000
//    };

//    employees.Add(teacher);

//    IEmployee headOfDeparment = new HeadOfDepartment
//    {
//        Id = 1,
//        FirstName = "Department",
//        LastName = "Head",
//        Salary = 50000
//    };

//    employees.Add(headOfDeparment);    
    
//    IEmployee deputyHeadMaster = new DeputyHeadMaster
//    {
//        Id = 1,
//        FirstName = "Deputy",
//        LastName = "Headmaster",
//        Salary = 60000
//    };

//    employees.Add(deputyHeadMaster);

//    IEmployee headMaster = new HeadMaster
//    {
//        Id = 1,
//        FirstName = "Head",
//        LastName = "Master",
//        Salary = 70000
//    };

//    employees.Add(headMaster);


//}



void SeedData(List<IEmployee> employees)
{
    IEmployee teacher = EmployeeFactory.GetInstance(EmployeeType.Teacher, 1, "Teacher", "X", 40000);
    employees.Add(teacher);

    IEmployee headOfDeparment = EmployeeFactory.GetInstance(EmployeeType.HeadOfDepartment, 1, "Department", "Head",50000);
    employees.Add(headOfDeparment);    
    
    IEmployee deputyHeadMaster = EmployeeFactory.GetInstance(EmployeeType.DeputyHeadMaster, 1,"Deputy","Headmaster",60000);
    employees.Add(deputyHeadMaster);

    IEmployee headMaster = EmployeeFactory.GetInstance(EmployeeType.HeadMaster, 1, "Head", "Master", 70000);
    employees.Add(headMaster);

}





decimal totalSalary = 0;
List<IEmployee> employees = new List<IEmployee>();

SeedData(employees);

//foreach (var employee in employees)
//{
//    totalSalary += employee.Salary;
//}

// Using Linq   
totalSalary = employees.Sum(x => x.Salary);

WriteLine($"Total Annual Salaries (Including bonus): {totalSalary} ");



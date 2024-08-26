namespace SchoolHR.Domain;

public static class EmployeeFactory
{
    public static IEmployee GetInstance(EmployeeType employeeType, int id, string FirstName, string LastName, decimal Salary)
    {
        IEmployee employee  = employeeType switch
        {
            EmployeeType.Teacher => EmployeeGenericFactory<IEmployee, Teacher>.GetInstance(),
            EmployeeType.HeadOfDepartment => EmployeeGenericFactory<IEmployee, HeadOfDepartment>.GetInstance(),
            EmployeeType.DeputyHeadMaster => EmployeeGenericFactory<IEmployee, DeputyHeadMaster>.GetInstance(),
            EmployeeType.HeadMaster => EmployeeGenericFactory<IEmployee, HeadMaster>.GetInstance(),
        };

        if (employee != null) {
            employee.Id = id;
            employee.FirstName = FirstName;
            employee.LastName = LastName;
            employee.Salary = Salary;
        }

        return employee;
    }
}
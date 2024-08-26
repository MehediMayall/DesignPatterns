namespace SchoolHR.Domain;

public class Employee : IEmployee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual decimal Salary { get; set; }
}

public class Teacher: Employee
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.02M); set => base.Salary = value; }
}

public class HeadOfDepartment: Employee
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.03M); set => base.Salary = value; }

}

public class DeputyHeadMaster: Employee
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.04M); set => base.Salary = value; }

}

public class HeadMaster: Employee
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.05M); set => base.Salary = value; }

}

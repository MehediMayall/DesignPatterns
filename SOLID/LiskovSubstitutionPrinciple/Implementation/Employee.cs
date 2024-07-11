namespace LiskovSubstitutionPrinciple;

public class Employee: IEmployee
{
    public int Id { get;  set;}
    public string Name { get;  set; }
    public virtual decimal GetMinimumSalary() =>  100000;
    public override string ToString() => $"ID: {Id}, Name: {Name}, Salary: {GetMinimumSalary()}";
}

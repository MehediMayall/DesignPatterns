namespace LiskovSubstitutionPrinciple;

public interface IEmployee
{
    int Id {get;set;}
    string Name {get;set;}
    decimal GetMinimumSalary();
    public virtual string ToString() 
    {
        var salary = GetMinimumSalary();
        return $"ID: {Id}, Name: {Name}, Salary: {salary}";        
    }

}

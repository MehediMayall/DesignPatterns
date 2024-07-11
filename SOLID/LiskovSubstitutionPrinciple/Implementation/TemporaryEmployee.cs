namespace LiskovSubstitutionPrinciple;

public class TemporaryEmployee : Employee
{
 
    public TemporaryEmployee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override decimal GetMinimumSalary() =>  60000;

    
    
}

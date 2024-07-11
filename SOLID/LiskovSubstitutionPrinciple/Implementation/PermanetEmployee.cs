namespace LiskovSubstitutionPrinciple;

public class PermanetEmployee : Employee, IEmployeeBonus
{   
    public PermanetEmployee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public decimal CalculateBonus(decimal salary) => salary * 0.1M;
    public override decimal GetMinimumSalary() =>  100000;    

    public override string ToString() 
    {
        var salary = GetMinimumSalary();
        return $"ID: {Id}, Name: {Name}, Salary: {salary}, Bonus: {CalculateBonus(salary)}";        
    }

}

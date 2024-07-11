namespace LiskovSubstitutionPrinciple;

public class ContractEmployee : Employee, IEmployeeBonus
{

    public ContractEmployee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public decimal CalculateBonus(decimal salary) => salary * 0.05M;
    public override decimal GetMinimumSalary() =>  80000; 

    public override string ToString() 
    {
        var salary = GetMinimumSalary();
        return $"ID: {Id}, Name: {Name}, Salary: {salary}, Bonus: {CalculateBonus(salary)}";        
    }   
}
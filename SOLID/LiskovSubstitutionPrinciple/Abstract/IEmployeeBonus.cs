namespace LiskovSubstitutionPrinciple;

public interface IEmployeeBonus: IEmployee
{
    decimal CalculateBonus(decimal salary);
    
}
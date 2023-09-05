namespace LazyLoading;

public class Employee
{

    public int Id { get; set; }
    public string EmployeeCode { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string Email { get; set; }

    public string ContactNumber { get; set; }

    public string PresentAddress { get; set; }
    public string PermanentAddress { get; set; }
    public DateTime DateOfBirth { get; set; }

    public DateTime JoiningDate {get; set; }


}
namespace ConsoleApp.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
}

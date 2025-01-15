namespace ConsoleApp.Entities;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; } = string.Empty;
    public ICollection<Employee>? Employees { get; set; }
}

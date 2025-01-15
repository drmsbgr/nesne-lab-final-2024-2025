using ConsoleApp.Entities;
using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class EmployeeService(EmployeeRepository employeeRepository)
{
    private readonly EmployeeRepository _employeeRepository = employeeRepository;

    public void AddEmployee(Employee emp)
    {
        _employeeRepository.Add(emp);
    }

    public decimal CalculateTotalMonthlySalary()
    {
        return _employeeRepository.GetAll().Sum(x => x.Salary);
    }

    public List<Employee> GetBySalaryRange(decimal min, decimal max)
    {
        return _employeeRepository.GetBySalaryRange(min, max);
    }
}
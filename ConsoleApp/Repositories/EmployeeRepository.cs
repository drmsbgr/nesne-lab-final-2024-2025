using ConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Repositories;

public class EmployeeRepository(RepositoryContext context) : RepositoryBase<Employee>(context)
{
    public List<Employee> GetAllEmployeesWithDepartment()
    {
        return GetAll().AsQueryable().Include(x => x.Department).OrderBy(s => s.EmployeeId).ToList();
    }

    public List<Employee> GetBySalaryRange(decimal min, decimal max)
    {
        return GetAll().Where(e => e.Salary >= min && e.Salary <= max).ToList();
    }
}

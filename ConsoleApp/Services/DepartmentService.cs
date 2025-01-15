using ConsoleApp.Repositories;

namespace ConsoleApp.Services;

public class DepartmentService(DepartmentRepository departmentRepository)
{
    private readonly DepartmentRepository _departmentRepository = departmentRepository;
}

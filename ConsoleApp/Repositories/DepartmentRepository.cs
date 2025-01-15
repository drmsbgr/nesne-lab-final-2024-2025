using ConsoleApp.Entities;

namespace ConsoleApp.Repositories;

public class DepartmentRepository(RepositoryContext context) : RepositoryBase<Department>(context)
{
}

using ConsoleApp.Entities;
using ConsoleApp.Repositories;

var context = new RepositoryContext();

var deps = new List<Department>()
{
    new(){DepartmentId = 1,DepartmentName = "HR"},
    new(){DepartmentId = 2,DepartmentName = "IT"},
    new(){DepartmentId = 3,DepartmentName = "Finance"},
};

AddDepartments(context, deps);


static void AddDepartments(RepositoryContext context, ICollection<Department> collection)
{
    context.Departments.AddRange(collection);
    context.SaveChanges();
}

using ConsoleApp.Entities;
using ConsoleApp.Repositories;
using ConsoleApp.Services;

var context = new RepositoryContext();

var deps = new List<Department>()
{
    new(){DepartmentId = 1,DepartmentName = "HR"},
    new(){DepartmentId = 2,DepartmentName = "IT"},
    new(){DepartmentId = 3,DepartmentName = "Finance"},
};

AddDepartments(context, deps);

var emps = new List<Employee>()
{
new () {EmployeeId = 1, FullName = "John Doe", Salary = 1000,DepartmentId = 1},
new () {EmployeeId = 2, FullName = "Jane Smith", Salary = 2000,DepartmentId = 2},
new () {EmployeeId = 3, FullName = "Alice Johnson", Salary = 3000,DepartmentId = 1},
new () {EmployeeId = 4, FullName = "Bob Williams", Salary = 2500,DepartmentId = 3},
new () {EmployeeId = 5, FullName = "Charlie Brown", Salary = 4000,DepartmentId = 2}
};

var empRepo = new EmployeeRepository(context);
var empService = new EmployeeService(empRepo);
emps.ForEach(e => empService.AddEmployee(e));


static void AddDepartments(RepositoryContext context, ICollection<Department> collection)
{
    context.Departments.AddRange(collection);
    context.SaveChanges();
}
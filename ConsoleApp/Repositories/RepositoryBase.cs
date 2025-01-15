namespace ConsoleApp.Repositories;

public class RepositoryBase<T>(RepositoryContext context) where T : class, new()
{
    protected readonly RepositoryContext _context = context;

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>();
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
}
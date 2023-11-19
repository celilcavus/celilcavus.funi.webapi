using System.Collections.Immutable;
using celilcavus.funi.Interfaces;
using Funi.Databases;

namespace celilcavus.funi.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
{
    private FuniContext context;

    public BaseRepository()
    {
        context = new FuniContext();
        
    }
    public void Add(T item)
    {
        context.Set<T>().Add(item);
        
    }

    public void Delete(T item)
    {
        context.Set<T>().Remove(item);
    }

    public IList<T> GetAll()
    {
        return context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return context.Set<T>().Find(id)!;
    }

    public int Save()
    {
       return context.SaveChanges();
    }

    public void Update(T item)
    {
       context.Set<T>().Update(item);
    }
}
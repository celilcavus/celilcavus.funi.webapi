namespace celilcavus.funi.Interfaces;

public interface IBaseRepository<T> where T : class,new()
{
    void Add(T item);
    void Update(T item);

    void Delete(T item);

    T GetById(int id);

    IList<T> GetAll();

    int Save();    
}
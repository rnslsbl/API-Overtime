namespace API_Overtime.Contracts
{
    public interface IGenericRepository<T>
    {
        T? Create(T item);
        bool Update(T item);
        bool Delete(Guid guid);
        IEnumerable<T> GetAll();
        T? GetByGuid(Guid guid);
    }
}

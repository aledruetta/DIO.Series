using System.Collections.Generic;

namespace DIO.Series.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(T item);
    }
}
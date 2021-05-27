using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetItemList();
        void Create(T item);
        T Read(int id);
        void Update(T item);
        void Delete(T item);
    }
}
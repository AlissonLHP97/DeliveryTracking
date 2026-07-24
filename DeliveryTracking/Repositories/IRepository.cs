using DeliveryTracking.Models.Base;

namespace DeliveryTracking.GenericRepository
{
    public interface IRepository <T> where T : Entity
    {
        T? FindById(long id);
        IEnumerable<T> FindAll();
        T Create (T entity);
        T Update(T entity);
        void Delete(long id);
        bool Exists (long id);
    }
}

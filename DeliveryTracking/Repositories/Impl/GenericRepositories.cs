using DeliveryTracking.Context;
using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTracking.Repositories.Impl
{
    public class GenericRepositories<T>(DeliveryTrackingDbContext context) : IRepository<T> where T : Entity
    {
        private readonly DeliveryTrackingDbContext _context = context;
        private readonly DbSet<T> _dataset = context.Set<T>();
       
        public T? FindById(long id)
        {
            return _dataset.Find(id);
        }

        public IEnumerable<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T Create(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public T Update(T entity)
        {
            var existingEntity = _dataset.Find(entity.Id);
            if (existingEntity == null) return null;
            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(long id)
        {
            var existingEntity = _dataset.Find(id);
            if(existingEntity == null) return;
           
            _context.Remove(existingEntity);
            _context.SaveChanges();
        }

        public bool Exists(long id)
        {
            return _dataset.Any(e => e.Id == id);
        }


    }
}

using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Service
{
    public class EntityService : IRepository<Employee>
    {
        private IRepository<Employee> _repository;
        public EntityService(IRepository<Employee> repository)
        {
            _repository = repository;
        }
        public Employee? FindById(long id)
        {
            return _repository.FindById(id);
        }
        public List<Employee> FindAll()
        {
            return _repository.FindAll();
        }

        public Employee Create(Employee entity)
        {
            return _repository.Create(entity);
        }
        public Employee Update(Employee entity)
        {
            return _repository.Update(entity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }



    }
}

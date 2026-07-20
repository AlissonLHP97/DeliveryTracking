using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Service.Impl
{
    public class EntityServiceImpl : IEmployeeService
    {
        private readonly IEmployeeService _repository;
        public EntityServiceImpl(IEmployeeService repository)
        {
            _repository = repository;
        }
        public Employee? FindById(long id)
        {
            return _repository.FindById(id);
        }
        public IEnumerable<Employee> FindAll()
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

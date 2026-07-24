using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Service.Impl
{
    public class EmployeeServiceImpl(IRepository<Employee> repository) : IEmployeeService
    {
        private readonly IRepository<Employee> _repository = repository;
        
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

        



    }
}

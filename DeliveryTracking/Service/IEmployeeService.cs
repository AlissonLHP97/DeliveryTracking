using DeliveryTracking.Models;

namespace DeliveryTracking.Service
{
    public interface IEmployeeService
    {
        Employee? FindById(long id);
        IEnumerable<Employee> FindAll();
        Employee Create(Employee entity);
        Employee Update(Employee entity);
        void Delete(long id);
    }
}

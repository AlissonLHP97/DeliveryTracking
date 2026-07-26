using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        bool ExistsByCpf(string cpf);
    }
}

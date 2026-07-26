using DeliveryTracking.Context;
using DeliveryTracking.Models;

namespace DeliveryTracking.Repositories.Impl
{
    public class EmployeeRepository : GenericRepositories<Employee>, IEmployeeRepository
    {
        private readonly DeliveryTrackingDbContext _context;
        public EmployeeRepository(DeliveryTrackingDbContext context) : base(context)
        {
            _context = context;
        }

        public bool ExistsByCpf(string cpf)
        {
            return _context.Employees.Any(c => c.Cpf == cpf);
        }
    }
}

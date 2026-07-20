using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Service.Impl
{
    public class DeliveryServiceImpl : IDeliveryService
    {
        private readonly IRepository<Delivery> _deliveryRepository;
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Epi> _epiRepository;

        public DeliveryServiceImpl(
            IRepository<Delivery> deliveryRepository,
            IRepository<Employee> employeerepository,
            IRepository<Epi> epiRepository)
        {
            _deliveryRepository = deliveryRepository;
            _employeeRepository = employeerepository;
            _epiRepository = epiRepository;            
        }

        private Employee GetEmployee(long employeeId)
        {
            var employee = _employeeRepository.FindById(employeeId);
            if (employee is null) throw new InvalidOperationException("Employee not found ");
            return employee;
        }
        private Epi GetEpi(long epiId)
        {
            var epi = _epiRepository.FindById(epiId);
            if (epi is null) 
                throw new InvalidOperationException("EPI not found ");

            return epi;
        }
        private void ValidateQuantity(int quantity)
        {
            if (quantity <= 0) 
                throw new ArgumentException("This value isn't allowed");
        }
        private void UpdateStock(Epi epi,  int quantity)
        {
            if (epi.QuantityInStock < quantity)
                throw new InvalidOperationException("Insufficient stock.");

            epi.QuantityInStock -= quantity;

            _epiRepository.Update(epi);
        }
        public IEnumerable<Delivery> FindAll()
        {
            return _deliveryRepository.FindAll().ToList();
        }

        public Delivery? FindById(long id)
        {
            return _deliveryRepository.FindById(id);
        }

        public Delivery Register(Delivery delivery)
        {
            GetEmployee(delivery.EmployeeId);

            var epi = GetEpi(delivery.EpiId);

            ValidateQuantity(delivery.Quantity);

            UpdateStock(epi, delivery.Quantity);
            
            return _deliveryRepository.Create(delivery);
        }
        
    }
}

using DeliveryTracking.DTO.Delivery;
using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;
using Mapster;

namespace DeliveryTracking.Service.Impl
{
    public class DeliveryServiceImpl
        (IRepository<Delivery> deliveryRepository,
        IRepository<Employee> employeerepository,
        IRepository<Epi> epiRepository) : IDeliveryService
    {
        private readonly IRepository<Delivery> _deliveryRepository = deliveryRepository;
        private readonly IRepository<Employee> _employeeRepository = employeerepository;
        private readonly IRepository<Epi> _epiRepository = epiRepository;

        private Employee GetEmployee(long employeeId)
        {
            var employee = _employeeRepository.FindById(employeeId);
            if (employee is null)
                throw new KeyNotFoundException("Employee not found");
            
            return employee;
        }
        private Epi GetEpi(long epiId)
        {
            var epi = _epiRepository.FindById(epiId);
            
            if (epi is null)
                throw new KeyNotFoundException("EPI not found");

            return epi;
        }
        private static void ValidateQuantity(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("This value isn't allowed");
        }
        private void UpdateStock(Epi epi, int quantity)
        {
            if (epi.QuantityInStock < quantity)
                throw new InvalidOperationException("Insufficient stock.");

            epi.QuantityInStock -= quantity;

            _epiRepository.Update(epi);
        }
        public IEnumerable<DeliveryResponseDTO> FindAll()
        {
            IEnumerable<Delivery> deliveries = _deliveryRepository.FindAll();
            return deliveries.Adapt<IEnumerable<DeliveryResponseDTO>>();
        }

        public DeliveryResponseDTO? FindById(long id)
        {
            var delivery = _deliveryRepository.FindById(id);

            if (delivery is null) throw new KeyNotFoundException("Delivery not found");

            return delivery.Adapt<DeliveryResponseDTO>();
        }

        public DeliveryRegisterDTO? Register(DeliveryRegisterDTO dto)
        {
            GetEmployee(dto.EmployeeId);

            var epi = GetEpi(dto.EpiId);

            ValidateQuantity(dto.Quantity);

            UpdateStock(epi, dto.Quantity);

            if (_deliveryRepository.Exists(dto.Id))
                throw new Exception("An Delivery with this ID already exists");

            var delivery = dto.Adapt<Delivery>();

            delivery = _deliveryRepository.Create(delivery);

            return delivery.Adapt<DeliveryRegisterDTO>();


        }

    }
}

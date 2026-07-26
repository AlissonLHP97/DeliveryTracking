using DeliveryTracking.DTO.Employee;
using DeliveryTracking.Models;

namespace DeliveryTracking.Service
{
    public interface IEmployeeService
    {
        EmployeeResponseDTO? FindById(long id);
        IEnumerable<EmployeeResponseDTO> FindAll();
        EmployeeCreateDTO Create(EmployeeCreateDTO dto);
        EmployeeUpdateDTO? Update(EmployeeUpdateDTO dto);       
        void Delete(long id);

    }
}

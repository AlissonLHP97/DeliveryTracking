using DeliveryTracking.DTO.Employee;
using DeliveryTracking.Models;
using DeliveryTracking.Repositories;
using Mapster;

namespace DeliveryTracking.Service.Impl
{
    public class EmployeeServiceImpl(IEmployeeRepository repository) : IEmployeeService
    {
        private readonly IEmployeeRepository _repository = repository;         
        public IEnumerable<EmployeeResponseDTO> FindAll()
        {
            IEnumerable<Employee> employees = _repository.FindAll();
            return employees.Adapt<IEnumerable<EmployeeResponseDTO>>();
        }
        public EmployeeResponseDTO? FindById(long id)
        {
            Employee? employee = _repository.FindById(id);
            if (employee is null) return null;

            return employee?.Adapt<EmployeeResponseDTO>();
        }

        public EmployeeCreateDTO Create(EmployeeCreateDTO dto)
        {
            if (_repository.ExistsByCpf(dto.Cpf))
                throw new Exception("An employee with this Cpf already exists");
            var employee = dto.Adapt<Employee>();

            employee = _repository.Create(employee);

            return employee.Adapt<EmployeeCreateDTO>();
        }
        public EmployeeUpdateDTO? Update(EmployeeUpdateDTO dto)
        {
            //Search employee by Id 
            var employee = _repository.FindById(dto.Id);
            //Validate if employee exists
            if (employee is null) return null;
            // Apply DTO values to existing employee entity
            dto.Adapt(employee);
            //Update the employee in database
            employee = _repository.Update(employee);
            //return updated employee as DTO
            return employee?.Adapt<EmployeeUpdateDTO>();
        }

        public void Delete(long id)
        {
            var employee = _repository.FindById(id);
            if (employee is null) return;
                
            _repository.Delete(id);
        }

    }
}

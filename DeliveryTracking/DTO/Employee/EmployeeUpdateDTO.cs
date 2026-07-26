using DeliveryTracking.Models.Base;

namespace DeliveryTracking.DTO.Employee
{
    public class EmployeeUpdateDTO : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
    }
}

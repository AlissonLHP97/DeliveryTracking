
using DeliveryTracking.Models.Base;

namespace DeliveryTracking.DTO.Employee
{
    public class EmployeeResponseDTO : Entity
    {
        public string Name { get; set; } = string.Empty;                
        public string Sector { get; set; } = string.Empty;
    }
}

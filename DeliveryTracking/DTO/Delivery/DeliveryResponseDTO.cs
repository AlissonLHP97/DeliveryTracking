using DeliveryTracking.Models.Base;

namespace DeliveryTracking.DTO.Delivery
{
    public class DeliveryResponseDTO : Entity
    {
        public string EmployeeName { get; set; } = string.Empty;

        public string EpiName { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public DateTime DateOfDelivery { get; set; }
    }
}


using DeliveryTracking.Models.Base;

namespace DeliveryTracking.DTO.Delivery
{
    public class DeliveryResponseDTO : Entity
    {
        public long EmployeeId { get; set; }
        public long EpiId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfDelivery { get; set; }
    }
}

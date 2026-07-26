using DeliveryTracking.Models.Base;

namespace DeliveryTracking.DTO.EPI
{
    public class EpiCreateDTO : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Ca { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }
    }
}

using DeliveryTracking.Models.Base;

namespace DeliveryTracking.DTO.EPI
{
    public class EpiUpdateDTO : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string? Ca { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
    }
}

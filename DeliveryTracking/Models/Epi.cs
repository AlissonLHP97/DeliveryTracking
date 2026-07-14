using DeliveryTracking.Models.Base;

namespace DeliveryTracking.Models
{
    public class Epi : Entity
    {
        public string Name { get; set; } = string.Empty;
        public int Ca { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }

        public ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
    }
}

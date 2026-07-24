using DeliveryTracking.Models.Base;
using System.Text.Json.Serialization;

namespace DeliveryTracking.Models
{
    public class Epi : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string? Ca { get; set; }
        public string Manufacturer { get; set; } = string.Empty;
        public int QuantityInStock { get; set; }

        [JsonIgnore]
        public ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
    }
}

using DeliveryTracking.Models.Base;
using System.Text.Json.Serialization;

namespace DeliveryTracking.Models
{
    public class Employee : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public DateOnly DateOfAdmission { get; set; }

        [JsonIgnore]
        public ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
        
}
}

using DeliveryTracking.Models.Base;

namespace DeliveryTracking.Models
{
    public class Employee : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public DateOnly DateOfAdmission { get; set; }

        public ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
        
}
}

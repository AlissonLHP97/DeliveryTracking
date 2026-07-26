using DeliveryTracking.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryTracking.Models
{
    public class Delivery : Entity
    {
        public long EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public long EpiId { get; set; }
        public Epi? Epi { get; set; } 
        public int Quantity { get; set; }
        public DateTime DateOfDelivery { get; set; }
    }
}

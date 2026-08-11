using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Repositories
{
    public interface IDeliveryRepository : IRepository<Delivery>
    {
        Delivery? FindByIdWithDetails(long id);
        IEnumerable<Delivery> FindAllWithDetails();
    }
}

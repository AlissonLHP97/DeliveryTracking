using DeliveryTracking.Models;

namespace DeliveryTracking.Service
{
    public interface IDeliveryService
    {
        IEnumerable<Delivery> FindAll();
        Delivery? FindById(long id);
        Delivery Register(Delivery delivery);

    }
}

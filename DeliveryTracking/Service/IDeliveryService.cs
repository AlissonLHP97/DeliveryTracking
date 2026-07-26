using DeliveryTracking.DTO.Delivery;

namespace DeliveryTracking.Service
{
    public interface IDeliveryService
    {
        IEnumerable<DeliveryResponseDTO> FindAll();
        DeliveryResponseDTO? FindById(long id);
        DeliveryRegisterDTO? Register(DeliveryRegisterDTO dto);
    }
}

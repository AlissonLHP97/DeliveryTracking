using DeliveryTracking.DTO.EPI;

namespace DeliveryTracking.Service
{
    public interface IEpiService
    {
        EpiResponseDTO? FindById(long id);
        IEnumerable<EpiResponseDTO> FindAll();
        EpiCreateDTO? Create(EpiCreateDTO dto);
        EpiUpdateDTO? Update(EpiUpdateDTO dto);
        void Delete(long id);

    }
}

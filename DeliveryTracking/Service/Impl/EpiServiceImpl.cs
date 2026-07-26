using DeliveryTracking.DTO.EPI;
using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;
using DeliveryTracking.Repositories;
using Mapster;

namespace DeliveryTracking.Service.Impl
{
    public class EpiServiceImpl(IEpiRepository repository) : IEpiService
    {
        private readonly IEpiRepository _repository = repository;

        public EpiResponseDTO? FindById(long id)
        {
            var epi = _repository.FindById(id);

            if (epi is null) return null;

            return epi?.Adapt<EpiResponseDTO>();
        }
        public IEnumerable<EpiResponseDTO> FindAll()
        {
            IEnumerable<Epi> epis = _repository.FindAll();

            return epis.Adapt<IEnumerable<EpiResponseDTO>>();
        }

        public EpiCreateDTO? Create(EpiCreateDTO dto)
        {
            if (_repository.Exists(dto.Ca))
                throw new Exception("An EPI with this CA already exists");

            var epi = dto.Adapt<Epi>();

            epi = _repository.Create(epi);

            return epi?.Adapt<EpiCreateDTO>();

        }
        public EpiUpdateDTO? Update(EpiUpdateDTO dto)
        {
            //Search epi by Id 
            var epi = _repository.FindById(dto.Id);
            //Validate if epi exists
            if (epi is null) return null;
            // Apply DTO values to existing epi entity
            dto.Adapt(epi);
            //Update the epi in database
            epi = _repository.Update(epi);
            //return updated epi as DTO
            return epi?.Adapt<EpiUpdateDTO>();
        }

        public void Delete(long id)
        {
            var epi = _repository.FindById(id);
            
            if(epi is null) return;

            _repository.Delete(id);
        }

    }
}

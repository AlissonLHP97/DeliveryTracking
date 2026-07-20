using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Service.Impl
{
    public class EpiService : IEpiService
    {
        private readonly IEpiService _repository;

        public EpiService(IEpiService repository)
        {
            _repository = repository;
        }

        public Epi? FindById(long id)
        {
            return _repository.FindById(id);
        }
        public IEnumerable<Epi> FindAll()
        {
            return _repository.FindAll();
        }

        public Epi Create(Epi entity)
        {
            return _repository.Create(entity);
        }
        public Epi Update(Epi entity)
        {
            return _repository.Update(entity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        
    }
}

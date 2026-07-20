using DeliveryTracking.Models;

namespace DeliveryTracking.Service
{
    public interface IEpiService
    {
        Epi? FindById(long id);
        IEnumerable<Epi> FindAll();
        Epi Create(Epi entity);
        Epi Update(Epi entity);
        void Delete(long id);

    }
}

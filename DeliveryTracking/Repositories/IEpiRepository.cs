using DeliveryTracking.GenericRepository;
using DeliveryTracking.Models;

namespace DeliveryTracking.Repositories
{
    public interface IEpiRepository : IRepository<Epi>
    {
        bool Exists(string ca);
    }
}

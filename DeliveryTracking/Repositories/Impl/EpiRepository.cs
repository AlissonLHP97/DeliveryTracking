using DeliveryTracking.Context;
using DeliveryTracking.Models;

namespace DeliveryTracking.Repositories.Impl
{
    public class EpiRepository : GenericRepositories<Epi>, IEpiRepository
    {
        private readonly DeliveryTrackingDbContext _context;
        public EpiRepository(DeliveryTrackingDbContext context) : base(context)
        {
            _context = context;
        }

        public bool Exists(string ca)
        {
            return _context.Epis.Any(e =>  e.Ca == ca);
        }
    }
}

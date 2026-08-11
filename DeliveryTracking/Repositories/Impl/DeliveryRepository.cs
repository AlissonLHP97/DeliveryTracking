using DeliveryTracking.Context;
using DeliveryTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTracking.Repositories.Impl
{
    public class DeliveryRepository(DeliveryTrackingDbContext context) 
        : GenericRepositories<Delivery>(context), IDeliveryRepository
    {
        private readonly DeliveryTrackingDbContext _context = context;

        public IEnumerable<Delivery> FindAllWithDetails()
        {
            return _context.Deliveries
                .Include(x => x.Employee)
                .Include(x => x.Epi)
                .ToList();
        }

        public Delivery? FindByIdWithDetails(long id)
        {
            return _context.Deliveries
                .Include(x => x.Employee)
                .Include(x => x.Epi)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}

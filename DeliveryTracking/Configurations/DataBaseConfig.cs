using DeliveryTracking.Context;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTracking.Configurations
{
    public static class DataBaseConfig
    {
        public static IServiceCollection AddDataBaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var stringConnection = configuration["MSSQLServerConnectionStrings:MSSQLServerConnection"];
            if (string.IsNullOrEmpty(stringConnection))
            {
                throw new ArgumentNullException("String Connection not found");
            }
            services.AddDbContext<DeliveryTrackingDbContext>(options =>
            options.UseSqlServer(stringConnection)
            );
            return services;

        }
    }
}


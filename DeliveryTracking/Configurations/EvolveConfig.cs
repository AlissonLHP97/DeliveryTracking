using EvolveDb;
using Microsoft.Data.SqlClient;

namespace DeliveryTracking.Configurations
{
    public static class EvolveConfig
    {
        public static IServiceCollection AddEvolveConfiguration(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            var stringConnection = configuration["MSSQLServerConnectionStrings:MSSQLServerConnection"];
            if (string.IsNullOrEmpty(stringConnection))
            {
                throw new ArgumentNullException("String Connection not found");
            }
            try
            {
                using var evolveConnection = new SqlConnection(stringConnection);
                var evolve = new Evolve(evolveConnection)
                {
                    Locations = new List<string> { "db/migrations", "db/dataset" },
                    IsEraseDisabled = true
                };
                evolve.Migrate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return services;
        }
    }
}

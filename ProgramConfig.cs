using Core.Database;
using Infrastructure.Config;

namespace BankAPI
{
    public static class ProgramConfig
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>();
        }

        public static void AddAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            AppConfig.Initialise(configuration);
        }
    }
}

using Core.Database;
using Core.Repositories;
using Core.Services;
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

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDepositRepository, DepositRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDepositService, DepositService>();
        }
    }
}

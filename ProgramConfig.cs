using Core.Database;

namespace BankAPI
{
    public static class ProgramConfig
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>();
        }
    }
}

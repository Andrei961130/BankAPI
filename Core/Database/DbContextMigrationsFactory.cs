
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore.Design;

namespace Core.Database
{
    public class DbContextMigrationsFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            AppConfig.MigrationsInit();

            return new DatabaseContext();
        }
    }
}

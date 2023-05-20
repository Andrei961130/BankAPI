
using Microsoft.EntityFrameworkCore;

namespace Core.Database
{
    public class DatabaseContext : DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "something";

            optionsBuilder
                .UseSqlServer(connectionString, opt => opt.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}


using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Core.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Deposit> Deposits { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = AppConfig.ConnectionStrings.MainDatabase;

            optionsBuilder
                .UseSqlServer(connectionString, opt => opt.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Deposit>()
                .Property(e => e.Amount)
                .HasPrecision(18, 2);
        }
    }
}

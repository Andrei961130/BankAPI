
using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Core.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Withdrawal> Withdrawals { get; set; }
        public DbSet<TradeOrder> TradeOrders { get; set; }
        public DbSet<TradeOrderType> TradeOrderTypes { get; set; }


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

            builder.Entity<Operation>()
                .Property(e => e.Amount)
                .HasPrecision(18, 2);

            builder.Entity<Withdrawal>()
                .Property(e => e.Amount)
                .HasPrecision(18, 2);

            builder.Entity<TradeOrder>()
                .Property(e => e.Amount)
                .HasPrecision(18, 2);
        }
    }
}

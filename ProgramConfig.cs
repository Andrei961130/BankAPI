using Core.Database;
using Core.Entities;
using Core.Repositories;
using Core.Services;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

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
            services.AddScoped<IOperationTypeRepository, OperationTypeRepository>();
            services.AddScoped<ITradeOrderRepository, TradeOrderRepository>();
            services.AddScoped<IWithdrawalRepository, WithdrawalRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDepositService, DepositService>();
            services.AddScoped<IOperationTypeService, OperationTypeService>();
            services.AddScoped<ITradeOrderService, TradeOrderService>();
            services.AddScoped<IWithdrawalService, WithdrawalService>();
        }
    }
}

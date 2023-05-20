

using Microsoft.Extensions.Configuration;

namespace Infrastructure.Config
{
    public static class AppConfig
    {
        public static ConnectionStrings ConnectionStrings { get; set; }

        public static void Initialise(IConfiguration configuration)
        {
            ConnectionStrings = new();
            configuration.Bind(nameof(ConnectionStrings), ConnectionStrings);
        }

        public static void MigrationsInit()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetCurrentDirectory()}/../")
                .AddJsonFile("appsettings.Local.json");

            var configuration = builder.Build();
            Initialise(configuration);
        }
    }
}

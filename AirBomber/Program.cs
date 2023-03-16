using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace AirBomber
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new();
            var config = BuildConfiguration();
            ConfigureServices(services, config);

            using (var scope = services.BuildServiceProvider())
            {
                Application.Run(scope.GetRequiredService<FormMapWithSetBombers>());
            }
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();

            services.AddSingleton(Log.Logger);
            services.AddSingleton(provider =>
            {
                var logger = provider.GetRequiredService<ILogger>();
                return new FormMapWithSetBombers(logger);
            });
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);

            return builder.Build();
        }
    }
}
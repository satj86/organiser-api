using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Organiser.Api.Configuration
{
    public static class SettingsExtensions
    {
        public static IServiceCollection ConfigureSettings<T>(this IServiceCollection services, string settingsGroup, IConfiguration configuration) where T : class, new()
        {
            var settings = configuration.GetSettings<T>(settingsGroup);
            services.AddSingleton(settings);

            return services;
        }
    }
}

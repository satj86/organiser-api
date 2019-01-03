using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Organiser.Api.Configuration
{
    public static class ConfigurationExtensions
    {
        public static T GetSettings<T>(this IConfiguration configuration, string settingsGroup) where T : class, new()
        {
            var settings = new T();
            configuration.Bind(settingsGroup, settings);

            return settings;
        }
    }
}

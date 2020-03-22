using Microsoft.Extensions.DependencyInjection;
using krambles.core.Services;

namespace krambles.infrastructure.Services
{
    public static class ServicesConfiguration
    {
        public static void AddKramblesInfrastructure(this IServiceCollection services)
        {
            services.AddKramblesCore();
        }
    }
}
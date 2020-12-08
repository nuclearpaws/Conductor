using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conductor.Infrastructure
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection @this, IConfiguration configuration)
        {
            // Register Infrastructure Classes for Dependency Injection Here:

            return @this;
        }
    }
}

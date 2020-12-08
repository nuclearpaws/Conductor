using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conductor.Core
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddCore(this IServiceCollection @this, IConfiguration configuration)
        {
            // Register Core Classes for Dependency Injection Here:

            return @this;
        }
    }
}

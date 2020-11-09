using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conductor.Data
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddData(this IServiceCollection @this, IConfiguration configuration)
        {
            // TODO: Add DI here:

            return @this;
        }
    }
}

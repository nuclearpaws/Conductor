using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Conductor.Core.Dependencies;
using Conductor.Core.Services.BasicImplementations;

namespace Conductor.Core
{
    public static class DependencyResolver
    {
        public static IServiceCollection AddCore(this IServiceCollection @this, IConfiguration configuration)
        {
            // Basic Implementations:
            @this.AddSingleton<IDateTimeProvider, BasicDateTimeProvider>();

            // TODO: Add DI here:

            return @this;
        }
    }
}

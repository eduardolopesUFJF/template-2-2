using Microsoft.Extensions.DependencyInjection;
using Template22.Infra.CrossCutting.IoC;

namespace Template22.Api.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
           Injector.RegisterServices(services);
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Template22.Domain.UsuarioRoot.Repository;
using Template22.Domain.UsuarioRoot.Service;
using Template22.Domain.UsuarioRoot.Service.Interfaces;
using Template22.Infra.Data.SqlServer.Context;
using Template22.Infra.Data.SqlServer.Repository;

namespace Template22.Infra.CrossCutting.IoC
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Service
            services.AddScoped<IUsuarioService, UsuarioService>();

            //Infra Data
            services.AddScoped<ServiceContext>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}

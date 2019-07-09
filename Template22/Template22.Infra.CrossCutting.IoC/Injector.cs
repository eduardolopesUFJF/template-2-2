using Microsoft.Extensions.DependencyInjection;
using Template22.Domain.LoginRoot.Service;
using Template22.Domain.LoginRoot.Service.Interfaces;
using Template22.Domain.SharedRoot.Repository;
using Template22.Domain.SharedRoot.Service;
using Template22.Domain.SharedRoot.Service.Interface;
using Template22.Domain.SharedRoot.UoW;
using Template22.Domain.SharedRoot.UoW.Interfaces;
using Template22.Infra.Data.SqlServer.Context;
using Template22.Infra.Data.SqlServer.Repository;

namespace Template22.Infra.CrossCutting.IoC
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Infra Data
            services.AddScoped<ServiceContext>();

            //Services
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<ILoginService, LoginService>();

            //Repository
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}

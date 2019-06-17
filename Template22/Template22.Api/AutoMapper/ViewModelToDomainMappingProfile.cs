using AutoMapper;
using Template22.Api.ViewModels;
using Template22.Domain.UsuarioRoot;

namespace Template22.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
           CreateMap<UsuarioVM, Usuario>();
        }
    }
}

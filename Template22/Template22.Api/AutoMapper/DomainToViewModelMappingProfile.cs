using AutoMapper;
using Template22.Api.ViewModels;
using Template22.Domain.UsuarioRoot;

namespace Template22.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioVM>();
        }
    }
}

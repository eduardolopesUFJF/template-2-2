using AutoMapper;
using Template22.Domain.UsuarioRoot;
using Template22.Domain.UsuarioRoot.DTO;

namespace Template22.Api.AutoMapper
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Usuario, UsuarioDTO>();
        }
    }
}

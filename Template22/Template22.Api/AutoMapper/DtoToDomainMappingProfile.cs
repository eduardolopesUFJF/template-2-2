using AutoMapper;
using Template22.Domain.UsuarioRoot;
using Template22.Domain.UsuarioRoot.DTO;

namespace Template22.Api.AutoMapper
{
    public class DtoToDomainMappingProfile : Profile
    {
        public DtoToDomainMappingProfile()
        {
           CreateMap<UsuarioDTO, Usuario>();
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Template22.Domain.SharedRoot.Service.Interface;
using Template22.Domain.UsuarioRoot;
using Template22.Domain.UsuarioRoot.DTO;

namespace Template22.Api.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IBaseService<Usuario> _baseUsuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(
            IBaseService<Usuario> baseUsuarioService,
            IMapper mapper)
        {
            _baseUsuarioService = baseUsuarioService;
            _mapper = mapper;
        }
       
        [HttpPost]
        public IActionResult Post(UsuarioDTO usuarioVM)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioVM);
            _baseUsuarioService.Adicionar(usuario);

            return Ok(usuario);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var usuariosVM = _baseUsuarioService.BuscarTodos();

            return Ok(usuariosVM);
        }
    }
}

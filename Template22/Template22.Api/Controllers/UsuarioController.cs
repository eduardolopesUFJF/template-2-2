using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Template22.Api.ViewModels;
using Template22.Domain.UsuarioRoot;
using Template22.Domain.UsuarioRoot.Service.Interfaces;
using System;

namespace Template22.Api.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }
       
        [HttpPost]
        public IActionResult Post(UsuarioVM usuarioVM)
        {
            try
            {
                Usuario usuario = _mapper.Map<Usuario>(usuarioVM);                
                _usuarioService.InserirUsuario(usuario);

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var usuariosVM = _usuarioService.GetAll();
                return Ok(usuariosVM);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

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

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
       
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioVM usuarioVM)
        {
            try
            {
                Usuario usuario = Mapper.Map<Usuario>(usuarioVM);
                _usuarioService.InserirUsuario(usuario);

                return Ok(true);
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

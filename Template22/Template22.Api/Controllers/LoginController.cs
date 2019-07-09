using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using Template22.Api.Security;
using Template22.Domain.LoginRoot.DTO;
using Template22.Domain.LoginRoot.Service.Interfaces;
using Template22.Domain.UsuarioRoot;

namespace Template22.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(
            ILoginService loginService)
        {
            _loginService = loginService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Logar([FromBody] DadosLoginDTO dadosLogin,
                                    [FromServices]SigningConfigurations signingConfigurations,
                                    [FromServices]TokenConfigurations tokenConfigurations)
        {
            var dadosUsuario = _loginService.Logar(dadosLogin);
            if (dadosUsuario != null)
            {
                var token = GerarToken(dadosUsuario, signingConfigurations, tokenConfigurations);
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
        }

        private static string GerarToken(Usuario dadosUsuario, SigningConfigurations signingConfigurations, TokenConfigurations tokenConfigurations)
        {
            ClaimsIdentity identity = new ClaimsIdentity(
                new GenericIdentity(dadosUsuario.Email, "email"),
                new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim("perfilId", dadosUsuario.PerfilId.ToString()),
                        new Claim("nome", dadosUsuario.Nome),
                        new Claim("email", dadosUsuario.Email)
                }
            );

            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = tokenConfigurations.Issuer,
                Audience = tokenConfigurations.Audience,
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });
            var token = handler.WriteToken(securityToken);

            return token;
        }
    }
}

using System.Linq;
using Template22.Domain.LoginRoot.DTO;
using Template22.Domain.LoginRoot.Service.Interfaces;
using Template22.Domain.SharedRoot.Repository;
using Template22.Domain.UsuarioRoot;

namespace Template22.Domain.LoginRoot.Service
{
    public class LoginService : ILoginService
    {
        private readonly IBaseRepository<Usuario> _baseRepository;

        public LoginService(
            IBaseRepository<Usuario> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Usuario Logar(DadosLoginDTO dadosLoginDTO)
        {
            if (RealizarAutenticacao(dadosLoginDTO))
            {
                var usuario = _baseRepository.Buscar(x => x.Nome.ToUpper().Equals(dadosLoginDTO.Usuario)).FirstOrDefault();
                return usuario;
            }
            else
            {
                return null;
            }
        }

        private bool RealizarAutenticacao(DadosLoginDTO dadosLoginDTO)
        {
            return true;
        }
    }
}

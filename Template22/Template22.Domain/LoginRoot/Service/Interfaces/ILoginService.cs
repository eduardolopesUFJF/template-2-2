using Template22.Domain.LoginRoot.DTO;
using Template22.Domain.UsuarioRoot;

namespace Template22.Domain.LoginRoot.Service.Interfaces
{
    public interface ILoginService
    {
        Usuario Logar(DadosLoginDTO dadosLoginDTO);
    }
}

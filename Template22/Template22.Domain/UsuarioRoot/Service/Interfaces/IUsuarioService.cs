using System.Collections.Generic;

namespace Template22.Domain.UsuarioRoot.Service.Interfaces
{
    public interface IUsuarioService
    {
        void InserirUsuario(Usuario usuario);
        List<Usuario> GetAll();
    }
}

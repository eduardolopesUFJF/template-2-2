using System.Collections.Generic;

namespace Template22.Domain.UsuarioRoot.Repository
{
    public interface IUsuarioRepository
    {
        void InserirUsuario(Usuario usuario);
        List<Usuario> GetAll();
        bool ValidarNomeUsuario(string nomeUsuario);
    }
}

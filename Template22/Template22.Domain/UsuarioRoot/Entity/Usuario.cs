using Template22.Domain.SharedRoot.Entity;

namespace Template22.Domain.UsuarioRoot
{
    public class Usuario : EntityBase
    {
        public string Nome { get; set; }
        public int PerfilId { get; set; }
        public string Email { get; set; }
    }
}

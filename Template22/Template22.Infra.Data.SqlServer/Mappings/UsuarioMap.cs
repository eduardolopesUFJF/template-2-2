using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template22.Domain.UsuarioRoot;

namespace Template22.Infra.Data.SqlServer.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(p => p.Nome)
                .HasColumnName("nome");

            builder.Property(p => p.PerfilId)
                .HasColumnName("perfilId");

            builder.Property(p => p.Email)
                .HasColumnName("email_principal");
        }
    }
}

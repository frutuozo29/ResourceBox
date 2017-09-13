using ResourceBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceBox.Infra.Data.EntityConfiguration
{
    public class RecursoEntityConfig : EntityTypeConfiguration<Recurso>
    {
        public RecursoEntityConfig()
        {
            HasKey(r => r.Id);

            Property(r => r.Descricao)
                .IsRequired()
                .HasMaxLength(80);

            Property(r => r.Observacao)
                .IsOptional()
                .HasMaxLength(255);
        }
    }
}

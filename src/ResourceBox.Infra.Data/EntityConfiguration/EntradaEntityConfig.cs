using ResourceBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceBox.Infra.Data.EntityConfiguration
{
    public class EntradaEntityConfig : EntityTypeConfiguration<Entrada>
    {
        public EntradaEntityConfig()
        {
            HasKey(e => e.Id);

            HasRequired(e => e.Responsavel)
                .WithMany()
                .HasForeignKey(e => e.ResponsavelId);
        }
    }
}

using ResourceBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceBox.Infra.Data.EntityConfiguration
{
    public class ResponsavelEntityConfig : EntityTypeConfiguration<Responsavel>
    {
        public ResponsavelEntityConfig()
        {
            HasKey(r => r.Id);

            Property(r => r.Nome)
                .IsRequired()
                .HasMaxLength(80);
        }
    }
}

using ResourceBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceBox.Infra.Data.EntityConfiguration
{
    public class RecursoEntradaEntityConfig : EntityTypeConfiguration<RecursoEntrada>
    {
        public RecursoEntradaEntityConfig()
        {
            HasKey(re => re.Id);
            /*
            HasRequired(re => re.Entrada)
                .WithMany()
                .HasForeignKey(re => re.EntradaId);*/

            HasRequired(re => re.Recurso)
                .WithMany()
                .HasForeignKey(re => re.RecursoId);
        }
    }
}

using ResourceBox.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceBox.Infra.Data.EntityConfiguration
{
    public class RecursoEntradaEntityConfig : EntityTypeConfiguration<RecursoEntrada>
    {
        public RecursoEntradaEntityConfig()
        {
            HasKey(re => re.Id);
        }
    }
}

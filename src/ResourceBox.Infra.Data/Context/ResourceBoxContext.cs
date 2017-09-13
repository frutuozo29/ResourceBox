using ResourceBox.Domain.Entities;
using ResourceBox.Infra.Data.EntityConfiguration;
using ResourceBox.Infra.Data.Migrations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ResourceBox.Infra.Data.Context
{
    public class ResourceBoxContext : DbContext
    {
        public ResourceBoxContext()
            : base("ResourceBoxDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ResourceBoxContext, Configuration>());
        }

        public DbSet<Recurso> Recursos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(200));

            modelBuilder.Configurations.Add(new RecursoEntityConfig());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

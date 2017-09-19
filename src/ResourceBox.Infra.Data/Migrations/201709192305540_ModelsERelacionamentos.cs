namespace ResourceBox.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModelsERelacionamentos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entrada",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        ResponsavelId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Responsavel", t => t.ResponsavelId)
                .Index(t => t.ResponsavelId);
            
            CreateTable(
                "dbo.RecursoEntrada",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Qtde = c.Long(nullable: false),
                        Entrada_Id = c.Long(),
                        Recurso_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entrada", t => t.Entrada_Id)
                .ForeignKey("dbo.Recurso", t => t.Recurso_Id)
                .Index(t => t.Entrada_Id)
                .Index(t => t.Recurso_Id);
            
            CreateTable(
                "dbo.Recurso",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 80, unicode: false),
                        Observacao = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Responsavel",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrada", "ResponsavelId", "dbo.Responsavel");
            DropForeignKey("dbo.RecursoEntrada", "Recurso_Id", "dbo.Recurso");
            DropForeignKey("dbo.RecursoEntrada", "Entrada_Id", "dbo.Entrada");
            DropIndex("dbo.RecursoEntrada", new[] { "Recurso_Id" });
            DropIndex("dbo.RecursoEntrada", new[] { "Entrada_Id" });
            DropIndex("dbo.Entrada", new[] { "ResponsavelId" });
            DropTable("dbo.Responsavel");
            DropTable("dbo.Recurso");
            DropTable("dbo.RecursoEntrada");
            DropTable("dbo.Entrada");
        }
    }
}

namespace ResourceBox.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntradaEResponsavelModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entrada",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Responsavel_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Responsavel", t => t.Responsavel_Id)
                .Index(t => t.Responsavel_Id);
            
            CreateTable(
                "dbo.Responsavel",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrada", "Responsavel_Id", "dbo.Responsavel");
            DropIndex("dbo.Entrada", new[] { "Responsavel_Id" });
            DropTable("dbo.Responsavel");
            DropTable("dbo.Entrada");
        }
    }
}

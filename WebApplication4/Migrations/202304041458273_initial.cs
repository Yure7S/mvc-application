namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Denuncias", "EnvolvidoId", "dbo.Envolvidoes");
            DropIndex("dbo.Denuncias", new[] { "EnvolvidoId" });
            AddColumn("dbo.Envolvidoes", "DenunciaId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Envolvidoes", "DenunciaId");
            AddForeignKey("dbo.Envolvidoes", "DenunciaId", "dbo.Denuncias", "Id", cascadeDelete: true);
            DropColumn("dbo.Denuncias", "EnvolvidoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Denuncias", "EnvolvidoId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Envolvidoes", "DenunciaId", "dbo.Denuncias");
            DropIndex("dbo.Envolvidoes", new[] { "DenunciaId" });
            DropColumn("dbo.Envolvidoes", "DenunciaId");
            CreateIndex("dbo.Denuncias", "EnvolvidoId");
            AddForeignKey("dbo.Denuncias", "EnvolvidoId", "dbo.Envolvidoes", "Id", cascadeDelete: true);
        }
    }
}

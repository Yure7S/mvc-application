namespace WebApplication4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Denuncias",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UsuarioId = c.Guid(nullable: false),
                        OrgaoDestino = c.String(nullable: false),
                        Assunto = c.String(nullable: false),
                        OrgaoAssunto = c.String(nullable: false),
                        Descricao = c.String(nullable: false),
                        Uf = c.String(nullable: false),
                        Municipio = c.String(nullable: false),
                        Local = c.String(nullable: false),
                        DataPostagem = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 128),
                        Senha = c.String(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Envolvidoes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DenunciaId = c.Guid(nullable: false),
                        Nome = c.String(),
                        Funcao = c.String(),
                        Empresa = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Denuncias", t => t.DenunciaId, cascadeDelete: true)
                .Index(t => t.DenunciaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Envolvidoes", "DenunciaId", "dbo.Denuncias");
            DropForeignKey("dbo.Denuncias", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Envolvidoes", new[] { "DenunciaId" });
            DropIndex("dbo.Usuarios", new[] { "Email" });
            DropIndex("dbo.Denuncias", new[] { "UsuarioId" });
            DropTable("dbo.Envolvidoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Denuncias");
        }
    }
}

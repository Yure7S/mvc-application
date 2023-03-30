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
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        UsuarioId = c.Guid(nullable: false),
                        OrgaoDestino = c.String(nullable: false),
                        Assunto = c.String(nullable: false),
                        OrgaoAssunto = c.String(nullable: false),
                        Descricao = c.String(nullable: false),
                        Uf = c.String(nullable: false),
                        Municipio = c.String(nullable: false),
                        Local = c.String(nullable: false),
                        NomeEnvolvido = c.String(nullable: false),
                        FuncaoEnvolvido = c.String(nullable: false),
                        OrgaoEmpresa = c.String(nullable: false),
                        DataPostagem = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Denuncias", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Denuncias", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Denuncias");
        }
    }
}

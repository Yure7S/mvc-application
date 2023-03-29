Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialMigration
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Denuncias",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .OrgaoDestino = c.String(nullable := False),
                        .Assunto = c.String(nullable := False),
                        .OrgaoAssunto = c.String(nullable := False),
                        .Descricao = c.String(nullable := False),
                        .Uf = c.String(nullable := False),
                        .Municipio = c.String(nullable := False),
                        .Local = c.String(nullable := False),
                        .NomeEnvolvido = c.String(nullable := False),
                        .FuncaoEnvolvido = c.String(nullable := False),
                        .OrgaoEnpresa = c.String(nullable := False),
                        .DataPostagem = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Usuarios",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Nome = c.String(nullable := False),
                        .Email = c.String(nullable := False),
                        .Senha = c.String(nullable := False),
                        .DataCadastro = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Usuarios")
            DropTable("dbo.Denuncias")
        End Sub
    End Class
End Namespace

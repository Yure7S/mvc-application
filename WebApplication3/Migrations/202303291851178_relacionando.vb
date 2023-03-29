Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class relacionando
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Denuncias", "UsuarioId", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.Denuncias", "UsuarioId")
            AddForeignKey("dbo.Denuncias", "UsuarioId", "dbo.Usuarios", "Id", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Denuncias", "UsuarioId", "dbo.Usuarios")
            DropIndex("dbo.Denuncias", New String() { "UsuarioId" })
            DropColumn("dbo.Denuncias", "UsuarioId")
        End Sub
    End Class
End Namespace

Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class orgao
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Pessoas", "Nome", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Pessoas", "Nome", Function(c) c.String())
        End Sub
    End Class
End Namespace

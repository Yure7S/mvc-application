Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class pessoa
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Pessoas",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Nome = c.String(),
                        .Sobrenome = c.String(),
                        .Idade = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Pessoas")
        End Sub
    End Class
End Namespace

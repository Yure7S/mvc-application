Imports System.Data.Entity

Public Class Pessoa

    Public Property Id() As Integer
    Public Property Nome() As Orgão

    Public Property Sobrenome() As String

    Public Property Idade() As Integer
End Class


Public Class PessoaDbContext : Inherits DbContext
    Public Property Pessoa() As DbSet(Of Pessoa)

End Class



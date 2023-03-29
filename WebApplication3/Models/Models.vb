Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel.DataAnnotations

Public Class Denuncia
    <Key>
    Public Property Id() As Integer


    <ForeignKey("UsuarioId")>
    Public Property Usuario() As Usuario
    Public Property UsuarioId() As Integer

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property OrgaoDestino() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property Assunto() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property OrgaoAssunto() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property Descricao() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property Uf() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property Municipio() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property Local() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property NomeEnvolvido() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property FuncaoEnvolvido() As String

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property OrgaoEnpresa() As String

    <Required()>
    Public Property DataPostagem() As Date

    Sub New()
        DataPostagem = Date.Now()
    End Sub

End Class

Public Class Usuario
    <Key>
    Public Property Id() As Integer

    <Required(ErrorMessage:="Campo obrigatório")>
    Public Property Nome() As String

    <EmailAddress>
    <Required(ErrorMessage:="Email inválido")>
    Public Property Email() As String

    <Required(ErrorMessage:="Senha inválida")>
    <MinLength(8, ErrorMessage:="Sua senha precisa conter no mínimo 8 caracteres")>
    Public Property Senha() As String

    <Required()>
    Public Property DataCadastro() As Date

    Sub New()
        DataCadastro = Date.Now()
    End Sub
End Class


Public Class OuvidoriaDbContext : Inherits DbContext
    Public Property Denuncia() As DbSet(Of Denuncia)
    Public Property Usuario() As DbSet(Of Usuario)
End Class




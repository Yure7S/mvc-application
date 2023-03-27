Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication3

Namespace Controllers
    Public Class PessoaController
        Inherits System.Web.Mvc.Controller

        Public dB As New PessoaDbContext
        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Create(pessoa As Pessoa) As ActionResult
            dB.Pessoa.Add(pessoa)
            dB.SaveChanges()

            Return RedirectToAction("Create")
        End Function

        Function Delete(id As Integer) As ActionResult
            Dim pessoa As Pessoa = dB.Pessoa.Find(id)
            Return View(pessoa)
        End Function

        <HttpPost>
        <ActionName("Delete")>
        Function DeleteConfirmed(id As Integer) As ActionResult
            Dim pessoa As Pessoa = dB.Pessoa.Find(id)
            dB.Pessoa.Remove(pessoa)
            dB.SaveChanges()
            Return RedirectToAction("Create")
        End Function


    End Class
End Namespace

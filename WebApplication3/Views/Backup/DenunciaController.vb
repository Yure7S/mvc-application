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
    Public Class OuvidoriaController
        Inherits System.Web.Mvc.Controller

        Public dB As New OuvidoriaDbContext

        Function Index() As ActionResult
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        Function Create(pessoa As Denuncia) As ActionResult
            dB.Denuncia.Add(pessoa)
            dB.SaveChanges()
            Return RedirectToAction("Create")
        End Function

        Function Delete(id As Integer) As ActionResult
            Dim pessoa As Denuncia = dB.Denuncia.Find(id)
            Return View(pessoa)
        End Function

        <HttpPost>
        <ActionName("Delete")>
        Function DeleteConfirmed(id As Integer) As ActionResult
            Dim pessoa As Denuncia = dB.Denuncia.Find(id)
            dB.Denuncia.Remove(pessoa)
            dB.SaveChanges()
            Return RedirectToAction("Create")
        End Function


        Function Destinatario(model As Denuncia) As ActionResult
            Return View(model)
        End Function

    End Class
End Namespace

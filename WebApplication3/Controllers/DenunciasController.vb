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
    Public Class DenunciasController
        Inherits System.Web.Mvc.Controller

        Private db As New OuvidoriaDbContext

        ' GET: Denuncias
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Denuncias/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim denuncia As Denuncia = db.Denuncia.Find(id)
            If IsNothing(denuncia) Then
                Return HttpNotFound()
            End If
            Return View(denuncia)
        End Function

        ' GET: Denuncias/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Denuncias/Create
        'Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        'obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,OrgaoDestino,Assunto,OrgaoAssunto,Descricao,Uf,Municipio,Local,NomeEnvolvido,FuncaoEnvolvido,OrgaoEnpresa,DataPostagem")> ByVal denuncia As Denuncia) As ActionResult
            If ModelState.IsValid Then
                db.Denuncia.Add(denuncia)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(denuncia)
        End Function

        ' GET: Denuncias/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim denuncia As Denuncia = db.Denuncia.Find(id)
            If IsNothing(denuncia) Then
                Return HttpNotFound()
            End If
            Return View(denuncia)
        End Function

        ' POST: Denuncias/Edit/5
        'Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        'obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,OrgaoDestino,Assunto,OrgaoAssunto,Descricao,Uf,Municipio,Local,NomeEnvolvido,FuncaoEnvolvido,OrgaoEnpresa,DataPostagem")> ByVal denuncia As Denuncia) As ActionResult
            If ModelState.IsValid Then
                db.Entry(denuncia).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(denuncia)
        End Function

        ' GET: Denuncias/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim denuncia As Denuncia = db.Denuncia.Find(id)
            If IsNothing(denuncia) Then
                Return HttpNotFound()
            End If
            Return View(denuncia)
        End Function

        ' POST: Denuncias/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim denuncia As Denuncia = db.Denuncia.Find(id)
            db.Denuncia.Remove(denuncia)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Function Destinatario(model As Denuncia) As ActionResult
            Return View(model)
        End Function
    End Class
End Namespace

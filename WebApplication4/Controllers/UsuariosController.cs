using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using WebApplication4.ViewModels;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication4.Controllers
{
    public class UsuariosController : Controller
    {
        private OuvidoriaDbContext db = new OuvidoriaDbContext();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Usuario.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Cadastro()
        {
            return View();
        }

        // POST: Usuarios/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastro([Bind(Include = "Id,Nome,Email,Senha,DataCadastro")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                Usuario usr = db.Usuario.FirstOrDefault(user => user.Email == usuario.Email);
                if (usr != null)
                {
                    ModelState.AddModelError("", "Usuário já cadastrado");
                }
                else
                {
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(usuario);
        }

        // Login de usuário
        public ActionResult RealizarLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RealizarLogin(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var getUser = db.Usuario.FirstOrDefault(user => user.Email == login.Email);

                if (getUser != null)
                {
                    if (getUser.SenhaValida(login.Senha))
                    {
                        FormsAuthentication.SetAuthCookie(getUser.Id.ToString(), false);
                        Session["Nome"] = getUser.Nome;
                        Session["Email"] = getUser.Email;
                        Session["Nome"] = getUser.Nome;
                        return RedirectToAction("Index", "Denuncias");
                    }

                    ModelState.AddModelError("", "Email ou senha inválidos");
                }
                else
                {
                    ModelState.AddModelError("", "Usuário não cadastrado, realize o cadastro para acessar sua conta");
                }

            }

            return View(login);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Email,Senha,DataCadastro")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

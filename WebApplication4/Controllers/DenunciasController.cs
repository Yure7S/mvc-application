using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Util;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    [Authorize]
    public class DenunciasController : Controller
    {
        private OuvidoriaDbContext db = new OuvidoriaDbContext();

        // GET: Denuncias
        public ActionResult Index()
        {
            var denuncia = db.Denuncia.Include(d => d.Usuario);
            return View(denuncia.ToList());
        }

        // GET: Denuncias/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Denuncia denuncia = db.Denuncia.Find(id);
            if (denuncia == null)
            {
                return HttpNotFound();
            }
            return View(denuncia);
        }

        // GET: Denuncias/Create
        
        public ActionResult Create()
        {
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome");
            return View();
        }

        // POST: Denuncias/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<ActionResult> Create(Denuncia denuncia)
        {
           
            if (ModelState.IsValid)
            {
                // Capturando o ID do usuário
                string usuarioAutenticado = User.Identity.Name;
                Usuario usuario = db.Usuario.FirstOrDefault(x => x.Email == usuarioAutenticado);
                denuncia.UsuarioId = usuario.Id;

                db.Denuncia.Add(denuncia);
                EnvioEmail envio = new EnvioEmail();
                await Task.Factory.StartNew(() => envio.sendEmail(denuncia.Usuario, denuncia));
                
               
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome", denuncia.UsuarioId);
            return View(denuncia);
        }

        // GET: Denuncias/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Denuncia denuncia = db.Denuncia.Find(id);
            if (denuncia == null)
            {
                return HttpNotFound();
            }
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome", denuncia.UsuarioId);
            return View(denuncia);
        }

        // POST: Denuncias/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Denuncia denuncia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(denuncia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UsuarioId = new SelectList(db.Usuario, "Id", "Nome", denuncia.UsuarioId);
            return View(denuncia);
        }

        // GET: Denuncias/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Denuncia denuncia = db.Denuncia.Find(id);
            if (denuncia == null)
            {
                return HttpNotFound();
            }
            return View(denuncia);
        }

        // POST: Denuncias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Denuncia denuncia = db.Denuncia.Find(id);
            db.Denuncia.Remove(denuncia);
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

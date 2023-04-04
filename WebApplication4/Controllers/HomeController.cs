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
    public class HomeController : Controller
    {
        private OuvidoriaDbContext db = new OuvidoriaDbContext();

        // GET: Denuncias
        public ActionResult Index()
        {
            var denuncia = db.Denuncia.Include(d => d.Usuario);
            return View(denuncia.ToList());
        }

    }
}

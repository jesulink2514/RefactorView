using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RefactorView.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Nuevo()
        {
            return View("Nuevo.Refactor");
        }
    }
}
using LenguajesAvanzados.MoldeDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LenguajesAvanzados.Controllers
{
    public class maxVentasController : Controller
    {
        VentasEntities db = new VentasEntities();
        // GET: maxVentas
        public ActionResult Index()
        {
            return View(db.salesPerProducts());
        }
    }
}
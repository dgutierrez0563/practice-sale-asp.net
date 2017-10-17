using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LenguajesAvanzados.Models;
using LenguajesAvanzados.MoldeDO;

namespace LenguajesAvanzados.Controllers
{
    public class FacturarsController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Facturars
        public ActionResult Index()
        {
            var facturars = db.Facturars.Include(f => f.Clientes).Include(f => f.Vendedors);
            return View(facturars.ToList());
        }

        public ActionResult imprimirFactura(int? id ) {
            VentasEntities db = new VentasEntities();
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                return View(db.imprimirFactura(id));
            }
        }

        public ActionResult verFactura(int? id) {
            VentasEntities db = new VentasEntities();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else {
                return View(db.verDetalleFactura(id));
            }            
        }

        // GET: Facturars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturar facturar = db.Facturars.Find(id);
            if (facturar == null)
            {
                return HttpNotFound();
            }
            return View(facturar);
        }

        // GET: Facturars/Create
        public ActionResult Create()
        {
            ViewBag.IDCliente = new SelectList(db.Clientes, "IDCliente", "Name");
            ViewBag.IDVendedor = new SelectList(db.Vendedors, "IDVendedor", "Name");
            return View();
        }

        // POST: Facturars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDFactura,IDCliente,IDVendedor,FechaCreado")] Facturar facturar)
        {
            if (ModelState.IsValid)
            {
                db.Facturars.Add(facturar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCliente = new SelectList(db.Clientes, "IDCliente", "Name", facturar.IDCliente);
            ViewBag.IDVendedor = new SelectList(db.Vendedors, "IDVendedor", "Name", facturar.IDVendedor);
            return View(facturar);
        }

        // GET: Facturars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturar facturar = db.Facturars.Find(id);
            if (facturar == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDCliente = new SelectList(db.Clientes, "IDCliente", "Name", facturar.IDCliente);
            ViewBag.IDVendedor = new SelectList(db.Vendedors, "IDVendedor", "Name", facturar.IDVendedor);
            return View(facturar);
        }

        // POST: Facturars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDFactura,IDCliente,IDVendedor,FechaCreado")] Facturar facturar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facturar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCliente = new SelectList(db.Clientes, "IDCliente", "Name", facturar.IDCliente);
            ViewBag.IDVendedor = new SelectList(db.Vendedors, "IDVendedor", "Name", facturar.IDVendedor);
            return View(facturar);
        }

        // GET: Facturars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facturar facturar = db.Facturars.Find(id);
            if (facturar == null)
            {
                return HttpNotFound();
            }
            return View(facturar);
        }

        // POST: Facturars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Facturar facturar = db.Facturars.Find(id);
            db.Facturars.Remove(facturar);
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

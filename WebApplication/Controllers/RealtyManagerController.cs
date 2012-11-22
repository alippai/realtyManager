using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealtyManager.Models;

namespace RealtyManager.Controllers
{
    public class RealtyManagerController : Controller
    {
        private RealtyContext db = new RealtyContext();

        //
        // GET: /RealtyManager/

        public ActionResult Index()
        {
            return View(db.Realties.ToList());
        }

        //
        // GET: /RealtyManager/Details/5

        public ActionResult Details(int id = 0)
        {
            Realty realty = db.Realties.Find(id);
            if (realty == null)
            {
                return HttpNotFound();
            }
            return View(realty);
        }

        //
        // GET: /RealtyManager/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RealtyManager/Create

        [HttpPost]
        public ActionResult Create(Realty realty)
        {
            if (ModelState.IsValid)
            {
                db.Realties.Add(realty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(realty);
        }

        //
        // GET: /RealtyManager/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Realty realty = db.Realties.Find(id);
            if (realty == null)
            {
                return HttpNotFound();
            }
            return View(realty);
        }

        //
        // POST: /RealtyManager/Edit/5

        [HttpPost]
        public ActionResult Edit(Realty realty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(realty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(realty);
        }

        //
        // GET: /RealtyManager/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Realty realty = db.Realties.Find(id);
            if (realty == null)
            {
                return HttpNotFound();
            }
            return View(realty);
        }

        //
        // POST: /RealtyManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Realty realty = db.Realties.Find(id);
            db.Realties.Remove(realty);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
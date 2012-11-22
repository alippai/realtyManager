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

        /*public ActionResult Index()
        {
            return View(db.Realties.ToList());
        }*/

        public ViewResult Index(string sortOrder)
        {
            ViewBag.AddressSortParm = String.IsNullOrEmpty(sortOrder) ? "Address desc" : "";
            ViewBag.SizeSortParm = sortOrder == "Size" ? "Size desc" : "Size";
            ViewBag.RoomSortParm = sortOrder == "Room" ? "Room desc" : "Room";
            ViewBag.TypeSortParm = sortOrder == "Type" ? "Type desc" : "Type";
            ViewBag.PriceSortParm = sortOrder == "Price" ? "Price desc" : "Price";
            var realties = from s in db.Realties select s;
            switch (sortOrder)
            {
                case "Address desc":
                    realties = realties.OrderByDescending(s => s.Address);
                    break;
                case "Room":
                    realties = realties.OrderBy(s => s.Room);
                    break;
                case "Room desc":
                    realties = realties.OrderByDescending(s => s.Room);
                    break;
                case "Size":
                    realties = realties.OrderBy(s => s.Size);
                    break;
                case "Size desc":
                    realties = realties.OrderByDescending(s => s.Size);
                    break;
                case "Type":
                    realties = realties.OrderBy(s => s.Type);
                    break;
                case "Type desc":
                    realties = realties.OrderByDescending(s => s.Type);
                    break;
                case "Price":
                    realties = realties.OrderBy(s => s.Price);
                    break;
                case "Price desc":
                    realties = realties.OrderByDescending(s => s.Price);
                    break;
                default:
                    realties = realties.OrderBy(s => s.Address);
                    break;
            }
            return View(realties.ToList());
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
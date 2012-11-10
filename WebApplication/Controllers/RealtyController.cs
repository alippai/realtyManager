using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class RealtyController : Controller
    {
        //
        // GET: /Realty/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Realty/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Realty/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Realty/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Realty/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Realty/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Realty/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Realty/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

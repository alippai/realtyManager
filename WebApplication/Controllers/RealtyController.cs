﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealtyManager.Models;

namespace RealtyManager.Controllers
{
    public class RealtyController : Controller
    {
        RealtyContext realtiesDB = new RealtyContext();

        // GET: /Realty/
        public ActionResult Index()
        {
            var realties = new List<Realty>
                {
                    new Realty { Address = "Almafa utca"},
                    new Realty { Address = "Mogyorobokor ut"},
                    new Realty { Address = "Kortefa ter"}
                };
            return View(realties);
        }
        //
        // GET: /Realty/Browse
        public ActionResult Browse(string username)
        {
            var realties = realtiesDB.Realties.ToList();
            return View(realties);
        }

    }
}

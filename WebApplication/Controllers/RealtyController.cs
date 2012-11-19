using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealtyManager.Models;

namespace RealtyManager.Controllers
{
    public class RealtyController : Controller
    {
        //
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
            var users = new UserProfile { UserName = username };
            return View(users);
        }

        //
        // GET: /Realty/Details
        public ActionResult Details(int id)
        {
            var realty = new Realty { Type = "Address " + id };
            return View(realty);
        }


    }
}

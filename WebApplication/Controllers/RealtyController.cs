using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RealtyManager.Models;
using System.Web;

namespace RealtyManager.Controllers
{
    public class RealtyController : Controller
    {
        public string Browse(string type)
        {
            string message = HttpUtility.HtmlEncode("Realty.Browse, Type = " + type);
            return message;
        }
    }
}

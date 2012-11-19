using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RealtyManager.Models;
using System.Web;

namespace RealtyManager.Controllers
{
    public class RealtyController : ApiController
    {
        static readonly IRealtyRepository repository = new RealtyRepository();

        public IEnumerable<Realty> GetAllRealties()
        {
            return repository.GetAll();
        }

        public Realty GetRealty(int id)
        {
            Realty realty = repository.Get(id);
            if (realty == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return View(realty);
        }

        public string Browse(string type)
        {
            string message = HttpUtility.HtmlEncode("Realty.Browse, Type = " + type);
            return message;
        }
    }
}

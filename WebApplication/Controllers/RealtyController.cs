using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using RealtyManager.Models;

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
            Realty item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        
    }
}

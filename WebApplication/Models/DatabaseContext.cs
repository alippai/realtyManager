using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;


namespace RealtyManager.Models
{
    public class RealtyContext : DbContext
    {
        public DbSet<Realty> Realties { get; set; }
        public RealtyContext():base("RealtyDB")
        {
            Configuration.ProxyCreationEnabled = false;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Database.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Realty> Realties { get; set; }
        public DatabaseContext()
        {
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
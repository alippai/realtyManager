using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;


namespace Realty.Models
{
    public class RealtyContext : DbContext
    {
        public DbSet<Realty> Realties { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        
        public RealtyContext() : base("DefaultConnection")
        {   
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}
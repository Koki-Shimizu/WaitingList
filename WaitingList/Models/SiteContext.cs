using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WaitingList.Models
{
    public class SiteContext : DbContext
    {
        public DbSet<Site> Sites { get; set; }
    }
}
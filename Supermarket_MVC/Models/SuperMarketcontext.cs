using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Supermarket_MVC.Models
{
    public class SuperMarketcontext : DbContext
    {
        public DbSet<RegisterModel> RegisterDetails { get; set; }
        public DbSet<Item_Details> ItemDetails { get; set; }
    }
}
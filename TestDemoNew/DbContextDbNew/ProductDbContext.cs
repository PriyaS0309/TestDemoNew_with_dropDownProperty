using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestDemoNew.Models;

namespace TestDemoNew.DbContextDbNew
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() 
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
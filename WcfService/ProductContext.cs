using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class ProductContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext() : base("ProductWCF")
        {
            Database.SetInitializer<ProductContext>(new DBInitializer());
        }
    }
}
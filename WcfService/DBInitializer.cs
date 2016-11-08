using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class DBInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product() { Name = "Pen",  Description = "Blue", Price = 10 });
            context.Products.Add(new Product() { Name = "Phone",  Description = "Samsung", Price = 1000 });
            context.Products.Add(new Product() { Name = "Shirt",  Description = "Red", Price = 300 });
           
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
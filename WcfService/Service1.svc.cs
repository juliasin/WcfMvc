using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
      
        public IEnumerable<Product> GetProducts()
        {
            ProductContext db = new ProductContext();
            List<Product> li = new List<Product>();
            li = db.Products.ToList();
            return li;
        }

        public void InsertProduct(Product pr)
        {
            ProductContext db = new ProductContext();
            db.Products.Add(pr);
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            ProductContext db = new ProductContext();
            var c = (from prod in db.Products where prod.Id == id select prod).First();
            db.Products.Remove(c);
            db.SaveChanges();
        }

        public void Update(Product pr)
        {
            ProductContext db = new ProductContext();
            var c = (from prod in db.Products where prod.Id == pr.Id select prod).First();
            c.Id = pr.Id;
            c.Name = pr.Name;
            c.Description = pr.Description;
            c.Price = pr.Price;
            db.SaveChanges();
        }
    }
}

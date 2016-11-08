using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.ServiceReference1;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
        // GET: Home
        public ActionResult Index()
        {
            
            return View(obj.GetProducts());
        }

        public ActionResult Delete(int id)
        {
            obj.Remove(id);
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Product p)
        {
            obj.InsertProduct(p);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Product p = new Product();
            var c = (from prod in obj.GetProducts() where prod.Id == id select prod).First();
            p.Id = c.Id;
            p.Name = c.Name;
            p.Description = c.Description;
            p.Price = c.Price;
            return View(p);
   
        }


        [HttpPost]
        public ActionResult Edit(Product p)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }

            obj.Update(p);
            return RedirectToAction("Index");
        }







    }
}
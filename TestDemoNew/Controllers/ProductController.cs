using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDemoNew.DbContextDbNew;
using TestDemoNew.Models;

namespace TestDemoNew.Controllers
{
    public class ProductController : Controller
    {
        //ProductDbContext db = new ProductDbContext();

        private readonly ProductDbContext db;
        public ProductController()
        {
            this.db = new ProductDbContext();
        }
        // GET: Product
        public ActionResult Index()
        {
            var list = db.Products.Where(model=>model.IsActive==true).ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();

            ModelState.Clear();
            return View();

        
        }

       // [HttpPost]
        public ActionResult Active(int id)
        {
            var product = db.Products.Single(c => c.ID == id);
            product.IsActive = false;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
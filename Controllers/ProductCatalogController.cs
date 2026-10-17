using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductCatalogPrac6.Models;

namespace ProductCatalogPrac6.Controllers
{
    public class ProductCatalogController : Controller
    {
        // GET: ProductCatalog
        public ActionResult Index()
        {
            List<Product> P = GetProducts();
            return View("Product", P);
        }

        // GET: ProductCatalog/Details/1
        public ActionResult Details(int id)
        {
            List<Product> all = GetProducts();
            Product p = all.FirstOrDefault(r => r.Id == id);

            if (p == null)
            {
                return HttpNotFound();
            }

            return View(p);
        }

        private List<Product> GetProducts()
        {
            List<Product> P = new List<Product>();

            Product p1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "15-inch laptop with 16GB RAM and 512GB SSD",
                Price = 30000,
                Category = "Electronics",
                Image = "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?q=80&w=687&auto=format&fit=crop"
            };
            Product p2 = new Product
            {
                Id = 2,
                Name = "Mobile",
                Description = "6.5-inch smartphone with 128GB storage",
                Price = 20000,
                Category = "Electronics",
                Image = "https://images.unsplash.com/photo-1598327105666-5b89351aff97?q=80&w=627&auto=format&fit=crop"
            };
            Product p3 = new Product
            {
                Id = 3,
                Name = "Laptop bag",
                Description = "Water-resistant bag that fits up to 15.6-inch laptops",
                Price = 1200,
                Category = "Accessories",
                Image = "https://images.unsplash.com/photo-1611461527944-1a718332613b?q=80&w=688&auto=format&fit=crop"
            };

            P.Add(p1);
            P.Add(p2);
            P.Add(p3);
            return P;
        }
    }
}
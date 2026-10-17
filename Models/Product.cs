using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCatalogPrac6.Models
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }
    }
}
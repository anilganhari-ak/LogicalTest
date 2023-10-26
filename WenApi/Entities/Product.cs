using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenApi.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }

        public Product(string productName, decimal price, string descripion)
        {
            this.Description = descripion;
            this.ProductName = productName;
            this.Price = price;
        }
    }
}

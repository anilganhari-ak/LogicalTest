using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenApi.Entities
{
    public interface IOfferService
    {
        public List<Product> GetProducts();
        public List<Offer> GetTodaysOffers();

        public void AddProduct(Product product);
    }
}

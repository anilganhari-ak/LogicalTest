using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WenApi.Entities
{
    public class OfferService: IOfferService
    {
        private List<Product> inventory = new List<Product>();

        private void CreateInventory()
        {
            inventory.Add(new Product("P1", 1000, "P1 desc"));
            inventory.Add(new Product("P2", 200, "P2 desc"));
            inventory.Add(new Product("P3", 400, "P3 desc"));
            inventory.Add(new Product("P4", 700, "P4 desc"));
            inventory.Add(new Product("P5", 600, "P5 desc"));
            inventory.Add(new Product("P6", 800, "P6 desc"));

        }

        public OfferService()
        {
            CreateInventory();
        }

        public List<Product> GetProducts()
        {
            return this.inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            var offers = new List<Offer>();
            offers.Add(GetRandomOffer("ComboPackage1"));
            offers.Add(GetRandomOffer("ComboPackage2"));
            offers.Add(GetRandomOffer("ComboPackage3"));
            offers.Add(GetRandomOffer("ComboPackage4"));

            return offers;
        }

        public void AddProduct(Product product)
        {
            inventory.Add(product);
        }

        private Offer GetRandomOffer(string offerName)
        {
            var products = new List<Product>();
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                products.Add(this.inventory[rnd.Next(0, 6)]);
            }
            return new Offer(offerName, products);
        }
    }
}

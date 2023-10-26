using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WenApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WenApi.Controllers
{
    [ApiController]
    public class OfferController : ControllerBase
    {
        private IOfferService _offerService;
        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;

        }
            // GET: api/<OfferController>
        [Route("allOffers")]
        public List<Offer> GetTodaysOffers()
        {
            return _offerService.GetTodaysOffers();
        }

        // GET api/<OfferController>/5
        [HttpGet("/products")]
        public List<Product> GetLowestProducts()
        {
            var products = _offerService.GetProducts();
            return products.OrderBy(x => x.Price).Take(3).ToList();
        }

        // GET api/<OfferController>/5
        [HttpGet("/secondleast")]
        public Product GetSencondLeast()
        {
            var products = _offerService.GetProducts();
            return products.OrderBy(x => x.Price).Skip(1).Take(1).FirstOrDefault();
        }

        // POST api/<OfferController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _offerService.AddProduct(product);
        }
    }
}

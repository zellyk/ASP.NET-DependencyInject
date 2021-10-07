using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class AmazonProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() { Id=1, Name="Item 1", Price= 1m },
                new Product() { Id=2, Name="Item 2", Price= 2m },
                new Product() { Id=3, Name="Item 3", Price= 3m },
            };
        }
    }
}

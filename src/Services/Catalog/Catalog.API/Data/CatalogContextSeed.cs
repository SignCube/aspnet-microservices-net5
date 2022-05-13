using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
        }


        public static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id  = "602d2149e773f2a3990b47f5",
                    Name = "Iphone X",
                    Summary = "This phone is the company,s bigget chanege",
                    Description ="Lorem Ipsum",
                    ImageFile  = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                }
            };
        }

    }
}

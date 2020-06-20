using System;
using System.Collections.Generic;

namespace LinqExperiments
{
    class Grocery
    {
        private List<Product> products;

        public Grocery()
        {
            // Create spaces in the console
            ConsoleLogger.Log(MessageType.NewTopic, "New Grocery instantiated!");
        }

        public List<Product> GetProducts()
        {
            if (products == null)
            {
                ConsoleLogger.Log(MessageType.Error, "There are no products in the Grocery. It was filled with test products!");

                return FillWithTestProducts();
            }
            
            return products;
        }

        public List<Product> FillWithTestProducts()
        {
            products = new List<Product>()
            {
                new Product() { Name = "Carrot", Price = 0.5f },
                new Product() { Name = "Olive Oil", Price = 10f },
                new Product() { Name = "Potato", Price = 0.25f },
                new Product() { Name = "Eggplant", Price = 19.99f },
                new Product() { Name = "Banana", Price = 2.25f },
                new Product() { Name = "Beetroot", Price = 6f },
                new Product() { Name = "Lemonade", Price = 3f },
                new Product() { Name = "Onion", Price = 0.1f },
                new Product() { Name = "Can of Air", Price = 0.01f },
                new Product() { Name = "Tomato", Price = 1.10f },
                new Product() { Name = "Avocado", Price = 12.25f },
            };

            return products;
        }
    }
}

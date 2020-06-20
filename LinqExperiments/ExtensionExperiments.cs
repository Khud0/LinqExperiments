using System.Collections.Generic;
using System.Linq;

namespace LinqExperiments
{
    class ExtensionExperiments : ITestable
    {
        private IEnumerable<IPricedObject> products;

        public ExtensionExperiments(IEnumerable<IPricedObject> products)
        {
            this.products = products;
        }

        public void Test()
        {
            float cheapPrice = Constant.CheapPrice;
            float expensivePrice = Constant.ExpensivePrice;

            // Print all product names in a single line
            var allProductNames = products
                                    .Select(p => p.Name)
                                    .OrderBy(p => p);

            ConsoleLogger.Log(MessageType.NewTopic, "All product names");
            ConsoleLogger.Log(MessageType.Info, string.Join(" | ", allProductNames));

            // Find the total price of all objects if we buy just one of each
            var totalPrice = products.Sum(p => p.Price);

            ConsoleLogger.Log(MessageType.NewTopic, "Total price of all products (1 unit each)");
            ConsoleLogger.PrintPricedObject(new Product { Name = "All Products", Price = totalPrice });

            // Print all products which cost less than cheapPrice in ascending order, filtered by Price
            var cheapProducts = products
                                    .Where(p => p.Price < cheapPrice)
                                    .OrderBy(p => p.Price);
            ConsoleLogger.Log(MessageType.NewTopic, $"Products which cost less than {cheapPrice}$");
            ConsoleLogger.PrintPricedObjects(cheapProducts);

            // Show the first 3 products out of all objects, sorted by their names
            var firstProductsByName = products
                                    .OrderBy(p => p.Name)
                                    .Take(3);

            ConsoleLogger.Log(MessageType.NewTopic, "First 3 products in the alphabet");
            ConsoleLogger.PrintPricedObjects(firstProductsByName);

            // Find the eggplant
            var eggplant = products.SingleOrDefault(p => p.Name.Equals("Eggplant"));

            ConsoleLogger.Log(MessageType.NewTopic, "Eggplant");
            ConsoleLogger.PrintPricedObject(eggplant);      
        }
    }
}

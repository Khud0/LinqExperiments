using System.Collections.Generic;
using System.Linq;

namespace LinqExperiments
{
    class QueryExperiments : ITestable
    {
        private IEnumerable<IPricedObject> products;

        public QueryExperiments(IEnumerable<IPricedObject> products)
        {
            this.products = products;
        }

        public void Test()
        {
            float expensivePrice = Constant.ExpensivePrice;

            // Print all products which cost more than expensivePrice in descending order, filtered by Price
            var expensiveProducts =
                from p in products
                where p.Price > expensivePrice
                orderby p.Price descending
                select p;

            ConsoleLogger.Log(MessageType.NewTopic, $"Products which cost more than {expensivePrice}$");
            ConsoleLogger.PrintPricedObjects(expensiveProducts);
        }
    }
}

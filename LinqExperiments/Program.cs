using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExperiments
{
    class Program
    {

        static void Main(string[] args) 
        {
            var grocery = new Grocery();
            var products = grocery.GetProducts();

            var query = new QueryExperiments(products);
            query.Test();

            var extension = new ExtensionExperiments(products);
            extension.Test(); 
            
            ConsoleLogger.Log(MessageType.NewTopic, "Program Executed");
        }
    }
}

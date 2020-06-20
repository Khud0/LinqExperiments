using System;
using System.Collections.Generic;

namespace LinqExperiments
{
    public enum MessageType
    {
        Error,
        NewTopic,
        Info
    }

    class ConsoleLogger
    {
        public static void PrintPricedObjects(IEnumerable<IPricedObject> products)
        {
            foreach (Product product in products)
                Console.WriteLine($"{product.Name}: {product.Price.ToString("#0.00")}$");
        }
        public static void PrintPricedObject(IPricedObject product)
        {
            Console.WriteLine($"{product.Name}: {product.Price.ToString("#0.00")}$");
        }

        public static void Log(MessageType messageType, string message)
        {
            switch (messageType)
            {
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: \"{message}\"");
                    break;

                case MessageType.NewTopic:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n--\"{message}\"--\n");
                    break;

                case MessageType.Info:
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{message}");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Log(string message)
        {
            Log(MessageType.Info, message);
        }
    }
}

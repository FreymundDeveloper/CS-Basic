using AdvancedConcepts.Entities;
using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvancedConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            Console.WriteLine("Enter the number of products:");
            int productsNumber = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < productsNumber; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string productType = Console.ReadLine()!;

                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (productType == "c")
                {
                    productsList.Add(new Product(name, price));
                }
                else if (productType == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    productsList.Add(new UsedProduct(name, price, DateTime.Parse(Console.ReadLine()!)));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    productsList.Add(new ImportedProduct(name, price, double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture)));

                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in productsList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}

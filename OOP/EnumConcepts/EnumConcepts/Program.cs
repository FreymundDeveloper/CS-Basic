using EnumConcepts.Entity;
using EnumConcepts.Entity.Enum;
using System;
using System.Globalization;

namespace EnumConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Email: ");
            string email = Console.ReadLine()!;
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter cliente data:\nStatus:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()!);

            Client client = new Client(name, email, birthDate);

            Order order = new Order(DateTime.Now ,status, client);

            Console.WriteLine("How many items to this order?");
            int orderQuantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < orderQuantity; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name:");
                string productName = Console.ReadLine()!;
                Console.Write("Product price:");
                double productPrice = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                Console.Write("Product quantity:");
                int productQuantity = int.Parse(Console.ReadLine()!);

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine($"ORDER SUMMMARY:\n{order.ReturnDataComplete()}");
        }
    }
}
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your complete name:");
            string? name = Console.ReadLine();

            Console.WriteLine("How many rooms have your house:");
            int? rooms = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter a price for the product:");
            double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Enter your name, age and height");
            string[] general = Console.ReadLine()!.Split(' ');

            Console.WriteLine($"{name} has a house with {rooms} rooms, a product with the price of {price.ToString("F2", CultureInfo.InvariantCulture)}. \n" +
                $"Old data: {general[0]} {general[1]} {general[2]}");
        }
    }
}
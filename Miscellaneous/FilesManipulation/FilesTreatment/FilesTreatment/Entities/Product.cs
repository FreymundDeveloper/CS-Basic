using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesTreatment.Entities
{
    internal class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string TotalPrice()
        {
            return $"{(Price * Quantity).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

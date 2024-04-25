using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConcepts.Entity
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product? Product { get; set; }

        public OrderItem(int quantity, double price, Product product) 
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }  

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public string ReturnData()
        {
            return $"{Product!.Name}, ${Price}, Quantity: {Quantity}, SubTotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

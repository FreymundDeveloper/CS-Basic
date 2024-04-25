using EnumConcepts.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConcepts.Entity
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client? Client { get; set; }
        public List<OrderItem>? Items { get; set;} = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client) 
        {
            Moment = moment;
            Status = status;    
            Client = client;
        }

        public void AddItem(OrderItem item) 
        {
            Items!.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items!.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items!)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public string ReturnDataComplete()
        {
            StringBuilder data = new StringBuilder();
            data.AppendLine($"Moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}\nStatus: {Status}\nClient: {Client!.ReturnData()}\nOrder items:");
            foreach (OrderItem item in Items!)
            {
                data.AppendLine(item.ReturnData());
            }
            data.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return data.ToString();
        }
    }
}

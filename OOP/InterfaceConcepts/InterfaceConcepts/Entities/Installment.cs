using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConcepts.Entities
{
    class Installment
    {
        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Installment(double amount, DateTime dueDate) 
        {
            Amount = amount;
            DueDate = dueDate;
        }

        public override string ToString()
        {
            return $"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

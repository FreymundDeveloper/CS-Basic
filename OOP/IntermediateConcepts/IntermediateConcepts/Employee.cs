using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IntermediateConcepts
{
    internal class Employee
    {
        public string? Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void SalaryIncrease(double percent)
        {
            GrossSalary += ((GrossSalary * percent) / 100);
        }

        public string DataReturn()
        {
            return Name + " - R$ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

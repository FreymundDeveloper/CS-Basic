using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLists
{
    internal class Emplyoee
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void SalaryIncrease(double percentage)
        {
            Salary += Salary * percentage / 100;
        }

        public string ReturnData()
        {
            return Id + ", " + Name + ", R$" + Salary;
        }
    }
}

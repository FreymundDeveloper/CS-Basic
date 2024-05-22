using LinqUse.Entities;
using System;
using System.Globalization;

namespace LinqUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter salary: ");
            double salaryLimit = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            using (StreamReader reader = File.OpenText(@"C:\Users\Lucas\Desktop\CS-Basic\Miscellaneous\LinqManipulation\Files\in.csv"))
            {

                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine()!.Split(',');

                    employees.Add(new Employee(data[0], data[1], double.Parse(data[2], CultureInfo.InvariantCulture)));
                }

                var emails = employees.Where(obj => obj.Salary > salaryLimit).OrderBy(obj => obj.Email).Select(obj => obj.Email);
                var sumOfM = employees.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                Console.WriteLine("Email of people whose salary is more than: " + salaryLimit.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine("\nSum of salary of people whose name starts with 'M':" + sumOfM.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
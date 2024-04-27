using AbstractionConcepts.Entities;
using System;
using System.Globalization;

namespace AbstractionConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayersNumber = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < taxPayersNumber; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                string payerType = Console.ReadLine()!;
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                
                if (payerType == "c")
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine()!);

                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                else 
                {
                    Console.Write("Health expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpeditures));
                }
            }

            double total = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer payer in list)
            {
                total += payer.Tax();
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
using InterfaceConcepts.Entities;
using InterfaceConcepts.Services;
using System;
using System.Globalization;

namespace InterfaceConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data\nNumber: ");
            int contractNumber = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Date (dd/MM/yyyy):");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());

            Console.WriteLine("Enter number of installments: ");
            contractService.ProcessContract(contract, int.Parse(Console.ReadLine()!));

            Console.WriteLine("Installments:\n");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
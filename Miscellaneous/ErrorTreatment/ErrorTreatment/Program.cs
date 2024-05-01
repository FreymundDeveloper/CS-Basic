using ErrorTreatment.Entities;
using ErrorTreatment.Entities.Exceptions;
using System;
using System.Globalization;

namespace ErrorTreatment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine()!);
            Console.Write("Holder: ");
            string holder = Console.ReadLine()!;
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");

            try
            {
                account.Withdraw(double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture));
                Console.WriteLine(account.ReturnData());
            } 
            catch (DomainException ex) {
                Console.WriteLine($"Withdraw error: {ex.Message}");            
            }
        }
    }
}
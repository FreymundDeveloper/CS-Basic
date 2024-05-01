using ErrorTreatment.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorTreatment.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string? Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) 
        {
            Number = number;   
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Insufficient balace");
            }
            if (amount > WithdrawLimit) 
            {
                throw new DomainException("Out of bounds");
            }
            Balance -= amount;
        }

        public string ReturnData()
        {
            return $"New balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

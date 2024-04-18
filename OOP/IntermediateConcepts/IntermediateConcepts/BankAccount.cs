using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IntermediateConcepts
{
    internal class BankAccount
    {
        public int CountNumber { get; private set; }
        public string? Owner { get; set; }
        public double Balance { get; private set; } = 0.0;

        public BankAccount(int countNumber, string owner) 
        {
            CountNumber = countNumber;
            Owner = owner;
        }

        public BankAccount(int countNumber, string owner, double balance) : this(countNumber, owner)
        {
            Deposit(balance);
        }

        public void Deposit(double value) 
        {
            Balance += value;
        }

        public void Withdrawal(double value) 
        {
            Balance -= (value + 5);
        }

        public string ReturnData() 
        {
            return "Account: " + CountNumber + ", Owner: " + Owner + ", Balance: R$" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

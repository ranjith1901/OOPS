using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{

    // Class representing a bank account
    public class BankAccount
    {
        // Private field to store the balance
        private decimal balance;

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            // Check if the deposit amount is positive
            if (amount > 0)
            {
                // Add the amount to the balance
                balance += amount;
            }
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            // Check if the withdrawal amount is positive and less than or equal to the balance
            if (amount > 0 && amount <= balance)
            {
                // Subtract the amount from the balance
                balance -= amount;
            }
        }

        // Method to get the current balance
        public decimal GetBalance()
        {
            // Return the current balance
            return balance;
        }
    }

    // Main program class
    class Encapsulation
    {
       public static void Run()
        {
            // Create a new bank account
            BankAccount account = new BankAccount();

            // Deposit money into the account
            account.Deposit(1000);
            Console.WriteLine("Deposited: 1000");

            // Withdraw money from the account
            account.Withdraw(500);
            Console.WriteLine("Withdrew: 500");

            // Get and display the current balance
            decimal balance = account.GetBalance();
            Console.WriteLine("Current Balance: " + balance);
        }
    }
}
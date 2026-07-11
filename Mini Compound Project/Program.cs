using System;
using System.Collections.Generic;

namespace MiniCompoundProject
{
    internal class Program
    {
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {

        }

        static void AddAccount()
        {
            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Account Number:");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Account number already exists.");
                return;
            }

            Console.WriteLine("Enter Initial Deposit:");
            double balance = Convert.ToDouble(Console.ReadLine());

            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
                return;
            }

            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(balance);

            Console.WriteLine("Account Created Successfully");
            Console.WriteLine("Customer: " + customerName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
        }
        static void DepositMoney()
        {
            Console.WriteLine("Enter Account Number:");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Enter Deposit Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balances[index] += amount;

            Console.WriteLine("Deposit Successful");
            Console.WriteLine("New Balance: " + balances[index]);
        }
        static void WithdrawMoney()
        {
            Console.WriteLine("Enter Account Number:");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Enter Withdrawal Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[index] -= amount;

            Console.WriteLine("Withdrawal Successful");
            Console.WriteLine("New Balance: " + balances[index]);
        }
        static void ShowBalance()
        {
            Console.WriteLine("Enter Account Number:");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.WriteLine("Customer Name: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine("Balance: " + balances[index]);
        }
    }
}
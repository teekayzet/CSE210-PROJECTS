using System;
using CsvHelper;
using System.Globalization;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a database object.
            Database database = new Database("AccountDetails.csv");

            // Create an error object.
            Error error = new Error("Invalid choice. Please try again.");

            // Prompt the user to log in or create a new account.
            Console.WriteLine("Welcome to the Bank Account System!");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Create a new account");
            Console.Write("Enter your choice: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                // Prompt the user to log in.
                Console.Write("Enter your account number: ");
                string accountNumber = Console.ReadLine();
                Console.Write("Enter your PIN: ");
                string pin = Console.ReadLine();
                // Authenticate the user.
                Authentication authentication = new Authentication();
                bool isAuthenticated = authentication.AuthenticateUser(database, error, accountNumber, pin);

                if (isAuthenticated)
                {
                    // Display the ATM transaction menu.
                    Console.WriteLine("ATM Transaction Menu");
                    Console.WriteLine("1. Balance Checking");
                    Console.WriteLine("2. Cash Withdrawal");
                    Console.WriteLine("3. Cash Deposition");
                    Console.WriteLine("4. Exit");

                    // Get the user's choice.
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    // Process the user's choice.
                    if (choice == 1)
                    {
                        // Retrieve the balance of the account.
                        decimal balance = database.GetBalance(accountNumber.ToString());

                        // Display the balance to the user.
                        Console.WriteLine("Your balance is: $" + balance);
                    }
                    else if (choice == 2)
                    {
                        // Withdraw money from the account.
                        Console.WriteLine("Enter the amount to withdraw: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        Withdrawal withdrawal = new Withdrawal("1234", accountNumber.ToString(), "Withdrawal", amount);
                        Account account = new Account("1234", (decimal)100.00, new List<Transaction>());
                        withdrawal.ProcessTransaction(account);
                    }
                    else if (choice == 3)
                    {
                        // Deposit money into the account.
                        Console.WriteLine("Enter the amount to deposit: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        Deposit deposit = new Deposit("ID", accountNumber.ToString(), "Deposit", amount);
                        Account account = new Account("1234", (decimal)100.00, new List<Transaction>());
                        deposit.ProcessTransaction(account);
                    }
                    else if (choice == 4)
                    {
                        // Exit the program.
                        Console.WriteLine("Thank you for using the Bank Account System!");
                        return;
                    }
                    else
                    {
                        // Display an error message to the user.
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }
            else if (choose == 2)
            {
                // Generate a new account number.
                Random random = new Random();
                int accountNumbr = random.Next(100000, 999999);

                // Prompt the user to create a new account.     
                Console.Write("Enter your full name: ");
                string fullName = Console.ReadLine();
                Console.Write("Enter your initial deposit amount: ");
                double initialDeposit = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a PIN: ");
                string pinn = Console.ReadLine();

                // Insert the new account into the CSV file.
                string filePath = "accounts.csv";
                using (var writer = new StreamWriter(filePath, true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecord(new Account(accountNumbr, fullName, initialDeposit, pinn));
                }

                // Display the new account number to the user.
                Console.WriteLine("Your account has been created successfully.");
                Console.WriteLine("Your account number is: " + accountNumbr);
                // Save the changes to the CSV file.
                database.SaveChanges();
            }
            else
            {
                // Display an error message to the user.
                Console.WriteLine("Invalid account number or PIN. Please try again.");
            }
        }
    }
}
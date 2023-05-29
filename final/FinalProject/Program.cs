using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args, string errorMessage)
        {
            // Create a database object.
            Database database = new Database();
            database.ConnectionString = "Data Source=localhost;Initial Catalog=BankAccount;Integrated Security=True";
            database.SQLCommands = new List<string> { "SELECT * FROM Accounts", "INSERT INTO Transactions (TransactionID, AccountNumber, TransactionType, Amount, Date/Time) VALUES (@TransactionID, @AccountNumber, @TransactionType, @Amount, @Date/Time)" };

            // Create an error object.
            Error error = new Error();

            // Prompt the user to log in.
            Console.WriteLine("Welcome to the Bank Account System!");
            Console.Write("Enter your account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your PIN: ");
            string pin = Console.ReadLine();

            // Authenticate the user.
            Authentication authentication = new Authentication();
            authentication.AccountNumber = accountNumber;
            authentication.PIN = pin;
            bool isAuthenticated = authentication.AuthenticateUser(database, error);

            if (isAuthenticated)
            {
                // Get the account details.
                Account account = new Account();
                account.AccountNumber = accountNumber;
                account.GetAccountDetails(database, error);

                // Get the balance of the account.
                decimal balance = account.GetBalance();

                // Display the balance to the user.
                Console.WriteLine("Your balance is: $" + balance);

                // Try to withdraw money from the account.
                try
                {
                    // Get the amount that the user wants to withdraw.
                    Console.Write("Enter the amount you want to withdraw: $");
                    double amount = Convert.ToDouble(Console.ReadLine());

                    // Calculate the transaction fee.
                    double transactionFee = amount * 0.01;

                    // Create a withdrawal object.
                    Withdrawal withdrawal = new Withdrawal((double)amount);
                    withdrawal.Amount = (double)amount;
                    withdrawal.transactionFee = transactionFee;

                    // Process the withdrawal transaction.
                    withdrawal.ProcessTransaction(account, database, authentication, error);

                    // Display the transaction details to the user.
                    Console.WriteLine("Transaction details:");
                    Console.WriteLine("Transaction ID: " + withdrawal.TransactionID);
                    Console.WriteLine("Account Number: " + withdrawal.AccountNumber);
                    Console.WriteLine("Transaction Type: " + withdrawal.TransactionType);
                    Console.WriteLine("Amount: $" + withdrawal.Amount);
                    Console.WriteLine("Transaction Fee: $" + withdrawal.TransactionFee);
                }
                catch (Exception)
                {
                    // Display the error message to the user.
                    Console.WriteLine(error.GenerateErrorMessage(errorMessage));
                }

                // Close the database connection.
                database.Disconnect();
            }
            else
            {
                // Display the error message to the user.
                Console.WriteLine(error.GenerateErrorMessage(errorMessage));
            }

            Console.WriteLine("Thank you for using the Bank Account System!");
        }
    }
}

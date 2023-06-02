using System.Collections.Generic;
using System.IO;

public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public List<Transaction> Transactions { get; set; }
    public int AccountNumbr { get; }
    public string FullName { get; }
    public double InitialDeposit { get; }
    public string Pinn { get; }

    public Account(string accountNumber, decimal balance, List<Transaction> transactions)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        Transactions = transactions;
    }

    public Account(int accountNumbr, string fullName, double initialDeposit, string pinn)
    {
        AccountNumbr = accountNumbr;
        FullName = fullName;
        InitialDeposit = initialDeposit;
        Pinn = pinn;
    }

    public void GetAccountDetails(Database database)
    {
        // read the account details from the CSV file
        string[] lines = File.ReadAllLines("AccountDetails.csv");

        foreach (string line in lines)
        {
            string[] fields = line.Split(',');

            // retrieve account details from the fields
            string accountNumber = fields[0];
            decimal accountBalance = decimal.Parse(fields[1]);
            List<Transaction> transactions = new List<Transaction>();
            // and so on...

            // create an Account object with the retrieved details
            Account account = new Account(accountNumber, accountBalance, transactions);

            // add the account to the database
            database.AddAccount(account);
        }
    }
}
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;


public class Database
{
    public string AccountsFilePath { get; set; }
    public List<Account> Accounts { get; set; }

    public Database(string accountsFilePath)
    {
        AccountsFilePath = accountsFilePath;
        Accounts = new List<Account>();
        LoadAccounts();
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
        SaveAccounts();
    }

    public decimal GetBalance(string accountNumber)
    {
        var account = Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        if (account != null)
        {
            return account.Balance;
        }
        else
        {
            throw new Exception("Account not found");
        }
    }
    private void LoadAccounts()
    {
        if (File.Exists(AccountsFilePath))
        {
            using (var reader = new StreamReader(AccountsFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var accountNumber = values[0];
                    var balance = decimal.Parse(values[1]);
                    var transactions = new List<Transaction>();
                    var account = new Account(accountNumber, balance, transactions);
                    Accounts.Add(account);
                }
            }
        }
    }

    private void SaveAccounts()
    {
        using (var writer = new StreamWriter(AccountsFilePath))
        {
            foreach (var account in Accounts)
            {
                writer.WriteLine($"{account.AccountNumber},{account.Balance}");
            }
        }
    }
    public void SaveChanges()
    {
        using (var writer = new StreamWriter(AccountsFilePath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(Accounts);
        }
    }
}
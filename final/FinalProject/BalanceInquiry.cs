public class BalanceInquiry
{
    public decimal AccountBalance { get; set; }

    public BalanceInquiry(decimal accountBalance)
    {
        AccountBalance = accountBalance;
    }

    public static BalanceInquiry GetBalance(int accountNumber)
    {
        // TODO: Implement this method
        try
        {
            // Get the balance from the database
            var balance = Database.GetBalance(accountNumber);

            // Return the balance
            return new BalanceInquiry(balance);
        }
        catch (Exception)
        {
            // Handle the exception
            // ...

            // Return null
            return null;
    }
}
}
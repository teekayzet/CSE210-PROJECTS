public abstract class Transaction
{
    public string TransactionID { get; set; }
    public string TransactionType { get; set; }

    public Transaction(string transactionID, string transactionType)
    {
        TransactionID = transactionID;
        TransactionType = transactionType;
    }
}
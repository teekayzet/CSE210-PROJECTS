public class Error
{
    public string ErrorMessage { get; set; }

    public Error(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }

    public Error()
    {
    }

    public static Error GenerateErrorMessage(string errorMessage)
    {
        return new Error(errorMessage);
    }

    internal object GenerateErrorMessage(object errorMessage)
    {
        throw new NotImplementedException();
    }
}

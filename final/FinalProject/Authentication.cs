using System.Data.SqlClient;
public class Authentication
{
public bool AuthenticateUser(Database database, Error error, string username, string password)
{
    // retrieve the user's details from the database
    string connectionString = "Data Source=your_server_name;Initial Catalog=your_database_name;Integrated Security=True";
    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Username", username);
        command.Parameters.AddWithValue("@Password", password);
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if (reader.HasRows)
        {
            // the user's credentials are valid
            return true;
        }
        else
        {
            // the user's credentials are invalid
            error.Message = "Invalid username or password";
            return false;
        }
    }
}
}
/** dotnet add package MySql.Data **/


using System;
using MySql.Data.MySqlClient; // Import the MySQL connector namespace

class Program
{
    static void Main()
    {
        // Define the connection string to connect to the 'finapp' database on localhost
        string connectionString = "Server=localhost;Database=finapp;User ID=root;Password=yourpassword;";

        // Initialize the MySqlConnection object to establish the connection
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                // Open the connection to the MySQL database
                connection.Open();
                Console.WriteLine("Connection to the MySQL database was successful!");

                // Optionally: Perform database operations here, such as querying or inserting data
                // For example, here we execute a simple SQL query to verify the connection

                string query = "SELECT NameClient FROM client LIMIT 1"; // Example query (fetch one client name)

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query and retrieve the result
                    var result = command.ExecuteScalar();  // ExecuteScalar returns the first column of the first row

                    if (result != null)
                    {
                        Console.WriteLine($"First client in the database: {result}");
                    }
                    else
                    {
                        Console.WriteLine("No data found in the 'client' table.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Catch any exceptions and print the error message
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // The connection will be automatically closed when exiting the 'using' block
                Console.WriteLine("Connection closed.");
            }
        }
    }
}

public class GlobalPortfolio
{
    // The NoPortfolio property represents the primary key for the global portfolio.
    // This value is typically auto-incremented by the database.
    public int NoPortfolio { get; set; }

    // The NoClient property is a foreign key referencing the client.
    // It links a global portfolio record to a specific client in the "client" table.
    public int NoClient { get; set; }

    // The Client property is a navigation property that allows access to the client
    // associated with this global portfolio. It establishes a relationship between
    // the global portfolio and the client.
    public Client Client { get; set; }
}

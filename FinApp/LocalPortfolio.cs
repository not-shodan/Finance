public class LocalPortfolio
{
    // The NoPortfolio property represents the primary key for the local portfolio.
    // This value is typically auto-incremented by the database.
    public int NoPortfolio { get; set; }

    // The NoClient property is a foreign key referencing the client.
    // It links a local portfolio record to a specific client in the "client" table.
    public int NoClient { get; set; }

    // The Client property is a navigation property that allows access to the client
    // associated with this local portfolio. It establishes a relationship between
    // the local portfolio and the client.
    public Client Client { get; set; }
}

public class Client
{
    // The NoClient property represents the primary key for the client record.
    // This value is typically auto-incremented by the database.
    public int NoClient { get; set; }

    // The NameClient property represents the name of the client.
    // It cannot be null based on the SQL schema (NOT NULL constraint).
    public string NameClient { get; set; }

    // The GlobalPortfolios property represents a collection of portfolios
    // associated with this client in the global portfolio table.
    // It's a navigation property that will allow us to access related global portfolios.
    public List<GlobalPortfolio> GlobalPortfolios { get; set; }

    // The LocalPortfolios property represents a collection of portfolios
    // associated with this client in the local portfolio table.
    // It's another navigation property to access the related local portfolios.
    public List<LocalPortfolio> LocalPortfolios { get; set; }

    // Constructor to initialize the navigation properties as empty collections.
    // This is important to avoid null reference exceptions when trying to access the collections.
    public Client()
    {
        GlobalPortfolios = new List<GlobalPortfolio>();
        LocalPortfolios = new List<LocalPortfolio>();
    }
}

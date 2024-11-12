public class Client
{
    public int NoClient { get; set; }

    public string NameClient { get; set; }

    // The GlobalPortfolios property represents a collection of portfolios
    // associated with this client in the global portfolio table.
    // It's a navigation property that will allow us to access related global portfolios.
    public List<GlobalPortfolio> GlobalPortfolios { get; set; }

    // The LocalPortfolios property represents a collection of portfolios
    public List<LocalPortfolio> LocalPortfolios { get; set; }

    // Constructor to initialize the navigation properties as empty collections.
    public Client()
    {
        GlobalPortfolios = new List<GlobalPortfolio>();
        LocalPortfolios = new List<LocalPortfolio>();
    }
}

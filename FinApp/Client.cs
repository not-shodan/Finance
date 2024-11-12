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










using System;

public class Client
{
    // Attributes
    public int NoClient { get; set; }
    public string NameClient { get; set; }
    public int NoPortfolios { get; set; }
    public double TotalPosition { get; set; }
    public int RiskScore { get; set; }

    // Constructor to initialize the attributes
    public Client(int noClient, string nameClient, int noPortfolios, double totalPosition, int riskScore)
    {
        NoClient = noClient;
        NameClient = nameClient;
        NoPortfolios = noPortfolios;
        TotalPosition = totalPosition;
        RiskScore = riskScore;
    }

    // Function to display the client details
    public void DisplayClientDetails()
    {
        Console.WriteLine("Client No: " + NoClient.ToString("D3"));
        Console.WriteLine("Name: " + NameClient);
        Console.WriteLine("Number of Portfolios: " + NoPortfolios);
        Console.WriteLine("Total Position: " + TotalPosition.ToString("C"));
        Console.WriteLine("Risk Score: " + RiskScore);
    }
}

class Program
{
    static void Main()
    {

using System;
using System.Collections.Generic;

public class Client
{
    // Attributes
    public int NoClient { get; set; }
    public string NameClient { get; set; }
    public int NoPortfolios { get; set; }
    public double GlobalPortfolio { get; set; }
    public double LocalPortfolio { get; set; } 
    public double TotalPosition { get; set; }
    public int RiskScore { get; set; }

    // Constructor to initialize the attributes
    public Client(int noClient, string nameClient, int noPortfolios, double globalPortfolio, double localPortfolio, double totalPosition, int riskScore)
    {
        NoClient = noClient;
        NameClient = nameClient;
        NoPortfolios = noPortfolios;
        GlobalPortfolio = globalPortfolio;
        LocalPortfolio = localPortfolio;
        TotalPosition = totalPosition;
        RiskScore = riskScore;
    }

    // Function to display the client details
    public void DisplayClientDetails()
    {
        Console.WriteLine("Client No: " + NoClient.ToString("D3"));
        Console.WriteLine("Name: " + NameClient);
        Console.WriteLine("Number of Portfolios: " + NoPortfolios);
        Console.WriteLine("Pos. Global Portfolio: " + GlobalPortfolio.ToString("C"));
        Console.WriteLine("Pos. Local Portfolio: " + LocalPortfolio.ToString("C"));
        Console.WriteLine("Total Position: " + TotalPosition.ToString("C"));
        Console.WriteLine("Risk Score: " + RiskScore);
        Console.WriteLine();  // Add an empty line for separation between clients
    }
}

class Program
{
    static void Main()
    {
        // Create a List of Client objects
        List<Client> clients = new List<Client>();

        // Adding 4 clients (one is the original client and 3 new clients)
        clients.Add(new Client(1, "Jack", 2, 500.00, 100000.00, 100500.00, 4));

        // Display the details of all clients in the list
        foreach (var client in clients)
        {
            client.DisplayClientDetails();
        }
    }
}

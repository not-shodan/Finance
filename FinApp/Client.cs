using System;
using System.Collections.Generic;

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
        clients.Add(new Client(1, "Jack", 2, 120500.00, 4));
        clients.Add(new Client(2, "Alice", 3, 250000.00, 5));
        clients.Add(new Client(3, "Bob", 1, 75000.00, 3));
        clients.Add(new Client(4, "Eve", 4, 500000.00, 2));

        // Display the details of all clients in the list
        foreach (var client in clients)
        {
            client.DisplayClientDetails();
        }
    }
}


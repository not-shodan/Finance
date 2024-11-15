using System;
using System.Collections.Generic;
using System.Linq;

class Client
{
    public int AccountNumber { get; set; }
    public string ClientName { get; set; }
    public static List<Client> Clients = new List<Client>();

    public static void CreateClient()
    {
        Console.Write("\nEnter Client Name: ");
        string name = Console.ReadLine();
        int accountNumber = Clients.Count + 1;
        Clients.Add(new Client { AccountNumber = accountNumber, ClientName = name });
        Console.WriteLine("\nClient created successfully!\n");
    }

    public static void ListClients()
    {
        if (Clients.Count == 0)
        {
            Console.WriteLine("\nNo clients found.\n");
            return;
        }

        foreach (var client in Clients) //lista de clientes, 
        {
            Console.WriteLine($"Account Number: {client.AccountNumber}, Name: {client.ClientName}");
        }
    }

    public static void DeleteClient()
    {
        Console.WriteLine("\nEnter Account Number to delete: \n");
        int accountNumber = int.Parse(Console.ReadLine());

        var client = Clients.FirstOrDefault(c => c.AccountNumber == accountNumber);
        if (client != null)
        {
            Clients.Remove(client);
            Console.WriteLine("\nClient deleted successfully!\n");
        }
        else
        {
            Console.WriteLine("\nClient not found.\n");
        }
    }

    public static int CountPortfolios(int accountNumber)
    {
        return Portfolio.Portfolios.Count(p => p.AccountNumber == accountNumber);
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Nothing to see here");
    }

}

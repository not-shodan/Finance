Below is the implementation in C# for the required classes, attributes, methods, and menus:

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
        Console.Write("Enter Client Name: ");
        string name = Console.ReadLine();
        int accountNumber = Clients.Count + 1;
        Clients.Add(new Client { AccountNumber = accountNumber, ClientName = name });
        Console.WriteLine("Client created successfully!");
    }

    public static void ListClients()
    {
        if (Clients.Count == 0)
        {
            Console.WriteLine("No clients found.");
            return;
        }

        foreach (var client in Clients)
        {
            Console.WriteLine($"Account Number: {client.AccountNumber}, Name: {client.ClientName}");
        }
    }

    public static void DeleteClient()
    {
        Console.WriteLine("Enter Account Number to delete: ");
        int accountNumber = int.Parse(Console.ReadLine());

        var client = Clients.FirstOrDefault(c => c.AccountNumber == accountNumber);
        if (client != null)
        {
            Clients.Remove(client);
            Console.WriteLine("Client deleted successfully!");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    public static int CountPortfolios(int accountNumber)
    {
        return Portfolio.Portfolios.Count(p => p.AccountNumber == accountNumber);
    }
}

class Portfolio
{
    public int PortfolioNumber { get; set; }
    public int AccountNumber { get; set; }
    public string PortfolioType { get; set; }
    public List<Stock> Stocks { get; set; } = new List<Stock>();

    public static List<Portfolio> Portfolios = new List<Portfolio>();

    public double PortfolioTotal
    {
        get { return Stocks.Sum(stock => stock.Quantity * stock.StockPrice); }
    }

    public static void CreatePortfolio()
    {
        Console.WriteLine("Select a Client by Account Number:");
        Client.ListClients();
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Portfolio Type (Global/Local): ");
        string portfolioType = Console.ReadLine();

        int portfolioNumber = Portfolios.Count + 1;
        Portfolios.Add(new Portfolio { PortfolioNumber = portfolioNumber, AccountNumber = accountNumber, PortfolioType = portfolioType });

        Console.WriteLine("Portfolio created successfully!");
    }

    public static void InsertStock()
    {
        Console.WriteLine("Select a Portfolio by Portfolio Number:");
        ListPortfolios();
        int portfolioNumber = int.Parse(Console.ReadLine());

        Portfolio portfolio = Portfolios.FirstOrDefault(p => p.PortfolioNumber == portfolioNumber);
        if (portfolio != null)
        {
            Stock.ListStocks();
            Console.Write("Enter Stock Name: ");
            string stockName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Stock stock = Stock.Stocks.FirstOrDefault(s => s.StockName == stockName);
            if (stock != null)
            {
                stock.Quantity = quantity;
                portfolio.Stocks.Add(stock);
                Console.WriteLine("Stock added to portfolio.");
            }
            else
            {
                Console.WriteLine("Stock not found.");
            }
        }
        else
        {
            Console.WriteLine("Portfolio not found.");
        }
    }

    public static void RemoveStock()
    {
        Console.WriteLine("Select a Portfolio by Portfolio Number:");
        ListPortfolios();
        int portfolioNumber = int.Parse(Console.ReadLine());

        Portfolio portfolio = Portfolios.FirstOrDefault(p => p.PortfolioNumber == portfolioNumber);
        if (portfolio != null)
        {
            Console.WriteLine("Select a Stock to Remove:");
            foreach (var stock in portfolio.Stocks)
            {
                Console.WriteLine($"Stock Name: {stock.StockName}");
            }

            string stockName = Console.ReadLine();
            var stockToRemove = portfolio.Stocks.FirstOrDefault(s => s.StockName == stockName);
            if (stockToRemove != null)
            {
                portfolio.Stocks.Remove(stockToRemove);
                Console.WriteLine("Stock removed.");
            }
            else
            {
                Console.WriteLine("Stock not found.");
            }
        }
        else
        {
            Console.WriteLine("Portfolio not found.");
        }
    }

    public static void ListPortfolios()
    {
        foreach (var portfolio in Portfolios)
        {
            Console.WriteLine($"Portfolio Number: {portfolio.PortfolioNumber}, Account Number: {portfolio.AccountNumber}, Type: {portfolio.PortfolioType}, Total Value: {portfolio.PortfolioTotal}");
        }
    }
}

class Stock
{
    public string StockName { get; set; }
    public double StockPrice { get; set; }
    public int Quantity { get; set; }

    public static List<Stock> Stocks = new List<Stock>();

    public static void CreateStock()
    {
        Console.Write("Enter Stock Name: ");
        string name = Console.ReadLine();

        if (Stocks.Any(s => s.StockName == name))
        {
            Console.WriteLine("Stock already exists.");
            return;
        }

        Console.Write("Enter Stock Price: ");
        double price = double.Parse(Console.ReadLine());

        Stocks.Add(new Stock { StockName = name, StockPrice = price });
        Console.WriteLine("Stock created successfully!");
    }

    public static void DeleteStock()
    {
        Console.WriteLine("Enter Stock Name to Delete:");
        string name = Console.ReadLine();

        var stock = Stocks.FirstOrDefault(s => s.StockName == name);
        if (stock != null)
        {
            Stocks.Remove(stock);
            Console.WriteLine("Stock deleted successfully!");
        }
        else
        {
            Console.WriteLine("Stock not found.");
        }
    }

    public static void ListStocks()
    {
        foreach (var stock in Stocks)
        {
            Console.WriteLine($"Stock Name: {stock.StockName}, Stock Price: {stock.StockPrice}");
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Clients");
            Console.WriteLine("2. Portfolios");
            Console.WriteLine("3. Stocks");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            int mainMenuChoice = int.Parse(Console.ReadLine());
            switch (mainMenuChoice)
            {
                case 1:
                    ClientMenu();
                    break;
                case 2:
                    PortfolioMenu();
                    break;
                case 3:
                    StockMenu();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void ClientMenu()
    {
        while (true)
        {
            Console.WriteLine("Clients Menu:");
            Console.WriteLine("1. Create Client");
            Console.WriteLine("2. List Clients");
            Console.WriteLine("3. Delete Client");
            Console.WriteLine("4. Main Menu");
            Console.Write("Select an option: ");

            int clientChoice = int.Parse(Console.ReadLine());
            switch (clientChoice)
            {
                case 1:
                    Client.CreateClient();
                    break;
                case 2:
                    Client.ListClients();
                    break;
                case 3:
                    Client.DeleteClient();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void PortfolioMenu()
    {
        while (true)
        {
            Console.WriteLine("Portfolios Menu:");
            Console.WriteLine("1. Create Portfolio");
            Console.WriteLine("2. List Portfolios");
            Console.WriteLine("3. Insert Stock into Portfolio");
            Console.WriteLine("4. Remove Stock from Portfolio");
            Console.WriteLine("5. Main Menu");
            Console.Write("Select an option: ");

            int portfolioChoice = int.Parse(Console.ReadLine());
            switch (portfolioChoice)
            {
                case 1:
                    Portfolio.CreatePortfolio();
                    break;
                case 2:
                    Portfolio.ListPortfolios();
                    break;
                case 3:
                    Portfolio.InsertStock();
                    break;
                case 4:
                    Portfolio.RemoveStock();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void StockMenu()
    {
        while (true)
        {
            Console.WriteLine("Stocks Menu:");
            Console.WriteLine("1. List Stocks");
            Console.WriteLine("2. Create Stock");
            Console.WriteLine("3. Delete Stock");
            Console.WriteLine("4. Main Menu");
            Console.Write("Select an option: ");

            int stockChoice = int.Parse(Console.ReadLine());
            switch (stockChoice)
            {
                case 1:
                    Stock.ListStocks();
                    break;
                case 2:
                    Stock.CreateStock();
                    break;
                case 3:
                    Stock.DeleteStock();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}

Explanation:

Each class contains the attributes and methods as specified.

The main menu allows navigation between Clients, Portfolios, and Stocks menus.

Each submenu implements the required functionality for creating, listing, and managing entities.



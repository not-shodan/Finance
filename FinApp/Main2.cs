using System;
using System.Collections.Generic;

namespace FinanceApp
{
    public class Client
    {
        public int AccountNumber { get; set; }
        public string ClientName { get; set; }
        public double GlobalPortfolio { get; set; }
        public double LocalPortfolio { get; set; }
        public List<Portfolio> Portfolios { get; set; }

        public double TotalPosition
        {
            get { return GlobalPortfolio + LocalPortfolio; }
        }

        public int CountPortfolios()
        {
            return Portfolios.Count;
        }

        public Client()
        {
            Portfolios = new List<Portfolio>();
        }
    }

    public class Portfolio
    {
        public int PortfolioNumber { get; set; }
        public int ClientNumber { get; set; }
        public string PortfolioType { get; set; } // "Local" or "Global"
        public List<Stock> Stocks { get; set; }

        public Portfolio()
        {
            Stocks = new List<Stock>();
        }
    }

    public class Stock
    {
        public string StockName { get; set; }
        public int Quantity { get; set; }
        public double LastPrice { get; set; }

        public double TotalValue
        {
            get { return Quantity * LastPrice; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize client
            Console.Write("Enter client name: ");
            string clientName = Console.ReadLine();

            Client client = new Client
            {
                AccountNumber = 1,
                ClientName = clientName,
                LocalPortfolio = 150000.00, // Example local portfolio value
                GlobalPortfolio = 0.0
            };

            // Create a local portfolio
            Portfolio localPortfolio = new Portfolio
            {
                PortfolioNumber = 101,
                ClientNumber = client.AccountNumber,
                PortfolioType = "Local"
            };

            // Input stocks in a loop
            Console.WriteLine("Enter stock details. Type 'end' to finish.");

            while (true)
            {
                Console.Write("Enter stock name (or 'end' to finish): ");
                string stockName = Console.ReadLine();

                if (stockName.ToLower() == "end") break;

                Console.Write("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter last price: ");
                double lastPrice = double.Parse(Console.ReadLine());

                // Create and add stock to portfolio
                Stock stock = new Stock
                {
                    StockName = stockName,
                    Quantity = quantity,
                    LastPrice = lastPrice
                };

                localPortfolio.Stocks.Add(stock);
            }

            // Add portfolio to client's list of portfolios
            client.Portfolios.Add(localPortfolio);

            // Print client and portfolio details
            Console.WriteLine("\nClient Information:");
            Console.WriteLine($"Name: {client.ClientName}");
            Console.WriteLine($"Total Position: USD {client.TotalPosition:N2}");
            Console.WriteLine($"Number of Portfolios: {client.CountPortfolios()}");

            Console.WriteLine("\nPortfolio Details:");
            foreach (var portfolio in client.Portfolios)
            {
                Console.WriteLine($"\nPortfolio Type: {portfolio.PortfolioType}");
                Console.WriteLine("Stocks:");
                foreach (var stock in portfolio.Stocks)
                {
                    Console.WriteLine($"- {stock.StockName}: Quantity = {stock.Quantity}, Last Price = USD {stock.LastPrice:N2}, Total Value = USD {stock.TotalValue:N2}");
                }
            }
        }
    }
}

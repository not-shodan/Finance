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
        public Dictionary<int, Stock> Stocks { get; set; }

        public Portfolio()
        {
            Stocks = new Dictionary<int, Stock>();
        }
    }

    public class Stock
    {
        public string StockName { get; set; }
        public int Quantity { get; set; }
        public double LastPrice { get; set; }
    }



    public class Grid
    {
        public string StockName { get; set; }
        public double LastPrice { get; set; }
        public double LastChange { get; set; } // Percentage
        public double LastSixMonths { get; set; } // Percentage
        public double LastTwelveMonths { get; set; } // Percentage
    }

    public class Simulations
    {
        public double CalculateRisk(Portfolio portfolio)
        {
            // Placeholder for risk calculation logic
            return 0.0; // Example return value
        }
    }



    public class Reports
    {
        public double ReturnPerformance(Portfolio portfolio)
        {
            // Placeholder for return performance calculation logic
            return 0.0; // Example return value
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize client
            Client client = new Client
            {
                AccountNumber = 1,
                ClientName = "Jack",
                LocalPortfolio = 150000.00,
                GlobalPortfolio = 0.0 // No global portfolio initially
            };

            // Create a local portfolio
            Portfolio localPortfolio = new Portfolio
            {
                PortfolioNumber = 101,
                ClientNumber = client.AccountNumber,
                PortfolioType = "Local"
            };

            // Add TSLA stock to portfolio
            Stock tslaStock = new Stock
            {
                StockName = "TSLA",
                Quantity = 5,
                LastPrice = 20.00
            };

            localPortfolio.Stocks.Add(1, tslaStock);

            // Add portfolio to client's portfolios
            client.Portfolios.Add(localPortfolio);

            // Print client details
            Console.WriteLine($"Client Name: {client.ClientName}");
            Console.WriteLine($"Total Position: USD {client.TotalPosition:N2}");
            Console.WriteLine($"Number of Portfolios: {client.CountPortfolios()} \n");

            // Calculate and print TSLA stock total
            double totalStockValue = tslaStock.Quantity * tslaStock.LastPrice;
			
            Console.WriteLine($"Stock: {tslaStock.StockName}");
			Console.WriteLine($"Quantity: {tslaStock.Quantity}");
			Console.WriteLine($"Last Price: USD {tslaStock.LastPrice:N2}");
            Console.WriteLine($"Total in {tslaStock.StockName} Stock Value: USD {totalStockValue:N2} \n");

            // Grid Example
            Grid stockGrid = new Grid
            {
                StockName = "TSLA",
                LastPrice = 20.00,
                LastChange = 2.0,
                LastSixMonths = 5.0,
                LastTwelveMonths = 7.0
            };

            Console.WriteLine($"Stock Performance:");
            Console.WriteLine($"- Last Price: USD {stockGrid.LastPrice:N2}");
            Console.WriteLine($"- Last Change: {stockGrid.LastChange}%");
            Console.WriteLine($"- Last Six Months: {stockGrid.LastSixMonths}%");
            Console.WriteLine($"- Last Twelve Months: {stockGrid.LastTwelveMonths}%");
        }
    }
}

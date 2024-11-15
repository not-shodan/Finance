using System;
using System.Collections.Generic;

namespace FinanceApp
{
    public class Client
    {
        public int AccountNumber { get; set; }
        public string ClientName { get; set; }
        public double TotalPosition 
        { 
            get 
            { 
                return GlobalPortfolio + LocalPortfolio; 
            } 
        }

        public double GlobalPortfolio { get; set; }
        public double LocalPortfolio { get; set; }
    }

    public class Portfolio
    {
        public int PortfolioNumber { get; set; }
        public int ClientNumber { get; set; }
        public string PortfolioType { get; set; } // "Local" or "Global"
        public Dictionary<int, List<string>> Stocks { get; set; }

        public Portfolio()
        {
            Stocks = new Dictionary<int, List<string>>();
        }
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
            Console.WriteLine("Calculating risk for portfolio...");
            return 0.0; // Example return value
        }
    }

    public class Reports
    {
        public double ReturnPerformance(Portfolio portfolio)
        {
            // Placeholder for return performance calculation logic
            Console.WriteLine("Calculating return performance for portfolio...");
            return 0.0; // Example return value
        }
    }
}
using System;

namespace FinanceApp
{
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
            Console.WriteLine($"Number of Portfolios: {client.CountPortfolios()}");

            // Calculate and print TSLA stock total
            double totalStockValue = tslaStock.Quantity * tslaStock.LastPrice;
            Console.WriteLine($"Stock: {tslaStock.StockName}, Quantity: {tslaStock.Quantity}, Last Price: USD {tslaStock.LastPrice:N2}");
            Console.WriteLine($"Total Stock Value: USD {totalStockValue:N2}");

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

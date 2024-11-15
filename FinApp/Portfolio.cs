using System.Collections.Generic;

namespace FinanceApp
{
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
}

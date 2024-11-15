namespace FinanceApp
{
    public class Grid
    {
        public string StockName { get; set; }
        public double LastPrice { get; set; }
        public double LastChange { get; set; } // Percentage
        public double LastSixMonths { get; set; } // Percentage
        public double LastTwelveMonths { get; set; } // Percentage
    }
}

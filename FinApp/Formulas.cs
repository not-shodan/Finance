using System;
using System.Threading.Tasks;
using YahooFinanceApi;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            // Retrieve historical data for TSLA from Yahoo Finance
            var securities = await Yahoo.GetHistoricalAsync("TSLA", DateTime.Now.AddDays(-5), DateTime.Now, Period.Daily);

            // Get the last available close price
            var lastClose = securities[0].Close;

            Console.WriteLine("Stock Name: TSLA");
            Console.WriteLine("Last Close: $" + lastClose);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

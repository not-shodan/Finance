using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Collect price data
        List<double> prices = new List<double> { 100, 102, 101, 98, 95, 96 }; // Example price data

        // Step 2: Create return series
        List<double> returns = new List<double>();
        for (int i = 1; i < prices.Count; i++)
        {
            double dailyReturn = (prices[i] - prices[i - 1]) / prices[i - 1];
            returns.Add(dailyReturn);
        }

        // Step 3: Estimate variance of return series
        double meanReturn = returns.Average();
        double variance = returns.Select(r => Math.Pow(r - meanReturn, 2)).Average();

        // Step 4: Calculate volatility (standard deviation)
        double volatility = Math.Sqrt(variance);

        // Step 5: Calculate 99% worst-case loss (VaR)
        double zScore99 = 2.33; // Z-score for 99% confidence level
        double positionSize = 10000; // Example position size in dollars
        double worstCaseLoss = zScore99 * volatility * positionSize;

        // Output results
        Console.WriteLine("Volatility (Standard Deviation): " + volatility);
        Console.WriteLine("99% Worst Case Loss (VaR): " + worstCaseLoss);
    }
}
using System;
using System.Linq;

class MonteCarloVaR
{
    static void Main(string[] args)
    {
        // Input parameters
        double portfolioValue = 1000000; // Portfolio value in dollars
        double meanReturn = 0.0005;      // Mean daily return (e.g., 0.05%)
        double volatility = 0.02;       // Daily volatility (e.g., 2%)
        int timeHorizon = 10;           // Time horizon in days
        int numSimulations = 100000;    // Number of Monte Carlo simulations
        double confidenceLevel = 0.95;  // Confidence level (e.g., 95%)

        // Perform Monte Carlo simulation
        double[] losses = new double[numSimulations];
        Random rand = new Random();

        for (int i = 0; i < numSimulations; i++)
        {
            double simulatedPortfolioValue = portfolioValue;

            // Simulate portfolio value over the time horizon
            for (int t = 0; t < timeHorizon; t++)
            {
                double randomShock = rand.NextDouble();
                double normalShock = MathNet.Numerics.Distributions.Normal.InvCDF(0, 1, randomShock);
                double dailyReturn = meanReturn + volatility * normalShock;
                simulatedPortfolioValue *= (1 + dailyReturn);
            }

            // Calculate portfolio loss
            losses[i] = portfolioValue - simulatedPortfolioValue;
        }

        // Calculate the VaR
        Array.Sort(losses);
        int varIndex = (int)((1 - confidenceLevel) * numSimulations);
        double var = losses[varIndex];

        Console.WriteLine($"Monte Carlo VaR at {confidenceLevel * 100}% confidence level over {timeHorizon} days: {var:C}");
    }
}

/**

1. Inputs:

portfolioValue: The initial value of the portfolio.
meanReturn and volatility: The portfolio's expected daily return and standard deviation.
timeHorizon: The number of days over which the simulation runs.
numSimulations: The number of Monte Carlo simulations.
confidenceLevel: The desired confidence level for the VaR calculation.

2. Simulation:

Generates random daily returns using a normal distribution.
Computes the portfolio value at the end of the time horizon for each simulation.

3. Sorting Losses:

Losses are sorted to find the percentile corresponding to the confidence level.

4. Output:

The VaR is the portfolio loss at the (1 - confidenceLevel) percentile.

Dependencies:

This code uses the MathNet.Numerics library for generating random samples from a normal distribution. You can install it via NuGet:

Install-Package MathNet.Numerics

**/

/**

1. Inputs:

Portfolio value ()
Expected return ()
Portfolio standard deviation ()
Confidence level ()

2. Calculation:

\text{VaR} = V \cdot z \cdot \sigma

**/

using System;

class ParametricVaR
{
    public static double CalculateVaR(double portfolioValue, double meanReturn, double stdDev, double confidenceLevel)
    {
        // Convert confidence level to z-score (assumes standard normal distribution)
        double zScore = GetZScore(confidenceLevel);

        // Calculate VaR
        double var = portfolioValue * zScore * stdDev;

        return var;
    }

    private static double GetZScore(double confidenceLevel)
    {
        // Example for confidence levels: 95% -> 1.645, 99% -> 2.33
        // Use the inverse of the cumulative distribution function (CDF) for a normal distribution.
        // Here we approximate for common confidence levels. For full flexibility, use a library like Math.NET.

        if (confidenceLevel == 0.95)
            return 1.645; // 95% confidence
        else if (confidenceLevel == 0.99)
            return 2.33; // 99% confidence
        else
            throw new ArgumentException("Confidence level not supported. Use 0.95 or 0.99.");
    }

    static void Main(string[] args)
    {
        // Example data
        double portfolioValue = 1000000; // $1,000,000
        double meanReturn = 0.001; // 0.1% daily mean return
        double stdDev = 0.02; // 2% daily volatility
        double confidenceLevel = 0.95; // 95% confidence

        // Calculate VaR
        double var = CalculateVaR(portfolioValue, meanReturn, stdDev, confidenceLevel);

        // Output result
        Console.WriteLine($"Parametric VaR at {confidenceLevel * 100}% confidence level: ${var:N2}");
    }
}


/**

1. Custom Confidence Levels: Use MathNet.Numerics for dynamic z-score calculations based on the standard normal distribution:

using MathNet.Numerics.Distributions;
double zScore = Normal.InvCDF(0, 1, confidenceLevel);

2. Scalability: Extend the program to handle multi-asset portfolios by integrating covariance matrices for portfolio standard deviation.

3. Error Handling: Add checks for input ranges, e.g., ensuring .

**/

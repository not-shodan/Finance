using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] numbers = {10, 20, 30, 40, 50};
        double mean = numbers.Average();

        double variance = numbers.Sum(x => Math.Pow(x - mean, 2)) / (numbers.Length - 1);

        Console.WriteLine($"Variance: {variance}");

        double standardDeviation = Math.Sqrt(variance);

        Console.WriteLine($"Standard Dev: {stadandarDeviation}");
    }
}

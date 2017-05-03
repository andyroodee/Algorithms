using System;
using Algorithms.Collections;
using Algorithms.StdLib;

namespace Algorithms.Clients
{
    public class BagClient
    {
        public static void Stats(string[] args)
        {
            Bag<double> numbers = new Bag<double>();

            double val;
            while (StdIn.TryReadDouble(out val))
            {
                numbers.Add(val);
            }

            int N = numbers.Count;
            double sum = 0.0;
            foreach (double x in numbers)
            {
                sum += x;
            }
            double mean = sum / N;

            sum = 0.0;
            foreach (double x in numbers)
            {
                sum += (x - mean) * (x - mean);
            }
            double std = Math.Sqrt(sum / (N - 1));
            StdOut.PrintFormat("Mean: {0:F2}\n", mean);
            StdOut.PrintFormat("Std dev: {0:F2}\n", std);
        }
    }
}

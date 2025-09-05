using System.Diagnostics;
using System.Numerics;

namespace primeCalculator;

public class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        // Get input from the user
        do
        {
            Console.Write("\nEnter an integer to check for prime: ");
            if (BigInteger.TryParse(Console.ReadLine()!.Trim(), out BigInteger myNumber))
            {
                stopwatch.Start();
                bool isPrime = checkIfPrime(myNumber);
                stopwatch.Stop();

                Console.WriteLine();
                Console.WriteLine(isPrime ? $"{myNumber} is prime" : $"{myNumber} is not prime.");
                Console.WriteLine($"Time take: {stopwatch.ElapsedMilliseconds} ms");
                // return;
            }
            else
                Console.WriteLine($"\nInput is not a valid integer. Enter a valid one.");

        } while (true);
    }

    static bool checkIfPrime(BigInteger n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (BigInteger i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

}

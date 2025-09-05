using System.Diagnostics;

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
            if (int.TryParse(Console.ReadLine()!.Trim(), out int myNumber))
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

    static bool checkIfPrime(int n)
    {
        int count = 0;

        for (int i = 2; i < n; i++)
        {
            if (n > 2 && n % i == 0)
            {
                count++;
            }
        }
        if (count > 0 || n<2)
            return false;
        else
            return true;
    }

}

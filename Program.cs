using System;

namespace sieveoferatosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new SieveOfEratosthenes();
            //Calling the Generate Sieve Method to find out the result.
            var results = obj.GenerateSieve(10);
            foreach (var item in results)
            {
                //Outputting iin the console.
                Console.WriteLine(item + " ");
            }
        }
    }

    public class SieveOfEratosthenes
    {
        // Build a Sieve of Eratosthenes.
        public bool[] GenerateSieve(int max)
        {
            // Creating an array indicating whether numbers are prime.
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++) is_prime[i] = true;

            // Crossing out multiples.
            for (int i = 2; i <= max; i++)
            {
                // Check if i is prime.
                if (is_prime[i])
                {
                    // Eliminate multiples of i.
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }
            return is_prime;
        }
    }
}

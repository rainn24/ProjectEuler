using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static partial class Utils
    {
        public static List<long> Sieve(long max)
        {
            bool[] numbers = new bool[max];
            numbers[0] = false;
            numbers[1] = false;
            for (int i = 2; i < max; i++)
            {
                numbers[i] = true;
            }

            for (int i = 2; i < max; i++)
            {
                if (numbers[i] == true)
                {
                    bool isPrime = true;
                    double sqrt = Math.Sqrt(i);
                    for (int x = 1; x < sqrt; x++)
                    {
                        if (numbers[x] == true)
                        {
                            if (i % x == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        for (int j = 2 * i; j < max; j += i)
                        {
                            numbers[j] = false;
                        }
                    }
                }
            }

            List<long> primes = new List<long>();

            for (long i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == true)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static List<long> PrimeGen(long max)
        {
            //return x number of primes

            List<long> primes = new List<long>();
            primes.Add(2);
            int x = 3;
            while (x < max)
            {
                bool isPrime = true;
                double sqrt = Math.Sqrt(x);
                foreach (long prime in primes)
                {

                    if (prime > sqrt)
                    {
                        break;
                    }
                    if (x % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(x);
                    Console.WriteLine("{0} is prime", x);

                }
                else
                {
                    Console.WriteLine(x);
                }
                x += 2;
            }
            return primes;
        }
    }
}

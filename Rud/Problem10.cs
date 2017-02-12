using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace ProjectEuler.Rud
{
    class Problem10 : Problem
    {
        public Problem10()
        {
            description =
@"The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.";

        }

        protected override void Solve()
        {
            var primes = Utils.Sieve(2000000);
            long sum = 0;
            foreach (var prime in primes)
            {
                sum += prime;
            }
            answer = sum.ToString();
        }
    }
}

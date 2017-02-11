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
            int max = 2000000;
            int sum = 0;
            for (int i = 2; i < max; i++)
            {
                if (Utils.factors(i).Count == 1)
                {
                    Console.WriteLine("{0} is Prime", i);
                    sum += i;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            answer = sum.ToString();
        }
    }
}

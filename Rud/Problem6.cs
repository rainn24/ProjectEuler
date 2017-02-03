using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Rud
{
    class Problem6 : Problem
    {
        public Problem6()
        {
            description =
@"The sum of the squares of the first ten natural numbers is,

1^2 + 2^2 + ... + 10^2 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)^2 = 55^2 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";

        }

        protected override void Solve()
        {
            int n = 100;
            long sumOfSquares = 0;
            long squareOfSums = 0;
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                sumOfSquares += i * i;
            }
            squareOfSums = sum * sum;
            answer = (squareOfSums - sumOfSquares).ToString();
        }
    }
}

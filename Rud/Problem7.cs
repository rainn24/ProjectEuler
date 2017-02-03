using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Rud
{
    class Problem7 : Problem
    {
        public Problem7()
        {
            description =
@"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10,001st prime number?";

        }

        protected override void Solve()
        {
            int i = 0;
            int count = 0;
            int num = 10001;
            do
            {
                i++;

                var factors = Utils.factors(i);
                if (factors.Count == 1)
                {
                    count++;
                }
            } while (count < num);

            answer = i.ToString();
        }
    }
}

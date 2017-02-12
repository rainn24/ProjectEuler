using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Rud
{
    class Problem5 : Problem
    {
        public Problem5()
        {
            description =
@"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
        }

        protected override void Solve()
        {
            int product = 1;
            List<int> factorList = new List<int>();
            for (int i = 2; i <= 20; i++)
            {
                var factors = Utils.factors(i);

                foreach (int factor in factors)
                {
                    int factorCount = factors.Count(x => x == factor); //how many times this factor appears in the number i

                    //check how often this factor appears in the overall list of factors
                    //and compare it to how many times it appears in this number's factors
                    while (factorList.Count(x => x == factor) < factorCount)
                    {
                        factorList.Add(factor);
                        product *= factor;
                    }
                }
            }
            answer = product.ToString();
        }
    }
}

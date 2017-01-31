using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static class Problem5
    {

        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        static public int Run()
        {

            int answer = 1;
            List<int> factorList = new List<int>();

            for (int i = 2; i <= 20; i++)
            {
                if (i == 8)
                {
                    var a = 1;
                }
                var factors = Utils.factors(i);

                for (int j = 0; j < factors.Count; j++)
                {
                    int factor = factors[j];    //a factor of the number i
                    int factorCount = factors.Count(x => x == factor); //how many times this factor appears in the number i

                    //check how often this factor appears in the overall list of factors
                    //and compare it to how many times it appears in this number's factors
                    int factorListCount = factorList.Count(x => x == factor);
                    while (factorListCount < factorCount)
                    {
                        factorList.Add(factor);
                        factorListCount++;
                    }                                                            
                }
            }


            foreach (int factor in factorList)
            {
                answer *= factor;
            }
            return answer;

        }
    }
}

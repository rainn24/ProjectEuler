using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace ProjectEuler.Rud
{
    class Problem9 : Problem
    {
        public Problem9()
        {
            description =
@"A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
 2   2   2
a + b = c
              2   2                 2
For example, 3 + 4 = 9 + 16 = 25 = 5.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";

        }

        protected override void Solve()
        {
            int max = 1000;
            for(int a = 1; a < max; a++)
            {
                for (int b = 1; b < max; b++)
                {
                    int cSquared = a * a + b * b;
                    double c = Math.Sqrt(cSquared);
                    if (c == Math.Round(c, 1))
                    {
                        int sum = a + b + (int) c;
                        if (sum == 1000)
                        {
                            answer = (a * b * c).ToString();
                            break;
                        }
                    }
                        
                }
            }
        }
    }
}

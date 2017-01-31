using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static partial class Utils
    {
        public static List<int> factors(long x)
        {
            //factor the number and return a list of all factors including multiples
            //ex: factors(8) should return a list containing [2, 2, 2]
            List<int> factors = new List<int>();

            for (long i = 2; i <= x; i++)
            {
                while (x % i == 0)
                {
                    factors.Add((int)i);
                    x /= i;
                }
            }
            return factors;
        }
    }
}

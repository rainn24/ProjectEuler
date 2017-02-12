using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static partial class Utils
    {
        [Obsolete("Use Utils.factors()")]
        public static List<int> factor(long x)
        {
            List<int> factors = new List<int>();

            for (long i = 2; i <= x; i++)
            {
                if (x % i == 0)
                {
                    factors.Add((int) i);
                    x /= i;
                }
            }

            return factors;
        }
    }
}

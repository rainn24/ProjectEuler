using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7J
    {
        static public int ProblemJ7()
        {
            int target = 0;
            int value = 10001;
            List<int> Primes = new List<int>();

            Primes = Utils.Primes(value);
            target = Primes.Last();


            return target;
        }
    }
}

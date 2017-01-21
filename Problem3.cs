using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static class Problem3
    {

        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?

        static public int Run()
        {
            //60085147514311 prime
            //60085147514312 isn't
            long x = 60085147514312;

            var factors = Utils.factor(x);

            return factors.Last();   
        }
    }
}

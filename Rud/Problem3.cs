using System.Linq;

namespace ProjectEuler.Rud
{
    class Problem3 : Problem
    {
        public Problem3()
        {
description = 
@"//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?";
        }


        protected override void Solve()
        {
            //60085147514311 prime
            //60085147514312 isn't
            long x = 60085147514312;

            var factors = Utils.factors(x);

            answer = factors.Last().ToString();   
        }
    }
}

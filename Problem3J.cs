using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    // The prime factors of 13195 are 5, 7, 13, and 29.
    //What is the largest prime factor of the number 600851475143?
    

    public class Problem3J
    {
        static public int ProblemJ3()
        {
            long source = 600851475143;
            int print = 0;
            var primeset = Utils.Primes(10000);
            List<int> foundprimes = new List<int>();

            foreach (var element in primeset)
            {
                if(source%element==0)
                {
                    if (element > source)
                    {
                        print = element;
                    }
               else
                    {
                        foundprimes.Add(element);
                        Console.WriteLine("Prime: " + element);
                        source = source / element;
                    }
                }
                

            }

            return foundprimes.Last();
        }
    }
}

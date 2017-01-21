using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static partial class Utils
    {
        public static List<int> Primes(long Val)
        {
            //Set # of primes to find with Val;

            List<int> primeindex = new List<int>();
            List<int> rawintegers = new List<int>();
            // Add first two primes to prime index.
            primeindex.Add(2);
            primeindex.Add(3);



            // Define primes through while loop using q as increment and primeindex as master index list.

            int q = 1;
            while (primeindex.Count() < Val)
            {

                if (q > (primeindex.Max()))
                {
                    int p = 0;
                    int max = primeindex.Last();
                    int count = primeindex.Count();
                    foreach (int j in primeindex)
                    {

                        if (q % j == 0)
                        {
                            break;              // Not a prime go to next integer

                        }

                        else if (p <= (count))
                        {
                            p++;
                            if (p >= count)
                            {
                                primeindex.Add(q);  // Is a prime, load into prime list.
                                break;              // Exit loop to next integer.
                            }

                            continue;           // Go to next prime to check.

                        }
                    }
                    q++;

                }
                else q++;
            }
            return primeindex;
        }
    }
}

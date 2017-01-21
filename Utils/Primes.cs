using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static partial class Utils
    {
        static List<int> Primes(long Val)
        {
            List<int> primeindex = new List<int>();
            List<int> rawintegers = new List<int>();

            long limit = (long)Math.Ceiling(Math.Sqrt(Val));
            // Make all integers.
            // { {1,0 },{2,0 },{3,0 },{4,0 } ..{ 10000,0} }
            // make array of all base integers to some value Val
            // List would have to define prime prior to adding it to the list. 

            primeindex.Add(2);
            primeindex.Add(3);

            for (int i = 1; i < Val; i++)
            {
                rawintegers.Add(i);
            }

            // Define primes.
            // { { 1,0 },{ 2,1 },{ 3,1 },{ 4,0 } ..{ 10000,0} }
            // Option 1: Check to see if known as prime<existing>. If not known check mod against known. If not found, assume prime, enter into storage.
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

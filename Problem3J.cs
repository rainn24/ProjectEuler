﻿using System;
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
            long limit = (long)Math.Ceiling(Math.Sqrt(source));
            
            
            //Set # of primes to find with Val;
            int Val = 10000;
            List<int> primeindex = new List<int> ();
            List<int> rawintegers = new List<int>();
            // Add first two primes to prime index.
            primeindex.Add(2);
            primeindex.Add(3);
            


            // Define primes through while loop using q as increment and primeindex as master index list.

            int q = 1;
            while (primeindex.Count()<Val)
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

            print = primeindex.Last();

            // Remove non primes by second value.
            // { {2,1 },{3,1 },{5,1 },{7,1 } ..{ 10000,0} } 

            // Divide number required to be prime with mod and mark as prime.
            // { {2,1 },{3,2 },{5,1 },{7,2 } ..{ 10000,0} }

            // Sort list by second digit to find all primes of said number.
            // { {2,2 },{7,2 },{,0 },{4,0 } ..{ 10000,0} }



            return print;
        }
    }
}
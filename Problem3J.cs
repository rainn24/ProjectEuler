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
            int i = 0;
            int indexval = 0;
            int Val = 10000;
            int[,] factindex = new int[Val,2];

            // make array of all base integers to some value Val
            for (i=0; i<val; i++)
            {
                factindex[i,0] = i;

               // { {1,0 },{2,0 },{3,0 },{4,0 } ..{ 10000,0} }
               
            }

            // set first known primes 1, and 2, 3.
            factindex[1, 1] = 1;
            factindex[2, 1] = 1;
            factindex[3, 1] = 1;



            for (i=1; i<10000; i++)
            {
                if (factindex[2*i,0])
                {
                 
                }

            }
            return print;
        }
    }
}

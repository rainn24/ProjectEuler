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
            int[,] factindex = new int[10000,2];


            for (i=0; i<10000; i++)
            {
                factindex[i,0] = i;
            }
            
            for (i=2; i<10000; i++)
            {
                if (factindex[i,0])
                {
                 
                }

            }
            return print;
        }
    }
}

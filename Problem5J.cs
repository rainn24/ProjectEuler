using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem5J
    {

        static public int ProblemJ5()
        {

            int j = 0;
            int end = 20;
            bool boo = true;
            int biggo = 1000000000;
            int Target = 0;
            List<List<int>> Primes = new List<List<int>>();

            for (int i = 0; i < end; i++)
            {
                Primes.Add(Utils.factor(i));
                
            }



            /*  This is the brute force method. Works but takes hours.
            while (boo)
            {

                for (int i = 0; i<biggo;i++)
                    {
                    Console.WriteLine("Current # is " + i);
                    if (Target>0)
                    {
                        break;
                    }
                        else
                    { 
                        for (j = 2; j < end+1; j++)
                        {
                            if(i%j==0)
                            {
                                if( j==end)
                                {
                                    Target = i;
                                    boo = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        else
                            {
                                break;
                            }
                        }
                    }

                }
                */


            return Target;
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6J
    {
        // Find the difference bewteen the sum of the squares of the first one hundred natural numbers and the square of the sum.

        static public int ProblemJ6()
        {
            int rawnum = 0;
            int sumNum = 0;
            int sumSquare = 0;
            int target = 0;
            int highVal = 100;


            for(int i = 1; i<(highVal+1); i++)
            {
                sumSquare += (i * i);
            }

            for(int j=1; j<(highVal+1); j++)
            {
                sumNum += j;
            }

            target = sumNum*sumNum - sumSquare;

            return target;
        }
    }
}

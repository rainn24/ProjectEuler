using System;
using System.Collections;


namespace ProjectEuler
{
    public class Problem1J
    {
        // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6, and 9. The sum of these multiples is 23.
        // Find the sum of all the multiples of 3 or 5 below 1000.

        static public int Class1()
        {

            ArrayList Numsel = new ArrayList();
            int p = 1000;
            int print = 0;

            for (int i = 0; i < p; i++)
            {
                if ((i % 3) == 0)
                {
                    Numsel.Add(i);
                }
                else if ((i % 5) == 0)
                {
                    Numsel.Add(i);
                }
            }
            foreach (int element in Numsel)
            {
                print = print + element;
            }
            return print;

        }

    }
}
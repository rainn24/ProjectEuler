﻿using System;
using System.Collections;
using System.Collections.Generic;



namespace ProjectEuler
{
    public class Problem2J
    {

        // Each new term in the Fibonacci sequence is generated by adding the previous  two terms. By starting with 1 and 2, the first 10 terms will be:
        // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,...
        // By considering the terms in the Fibonacci sequence whose values do not exceed 4 million (4,000,000), find the sum of the even-valued terms.

        static public int ProblemJ2()
        {
            int i = 0;
            int previous = 1;
            int p = 4000000;
            int print = 0;
            int incr = 0;

            List <int> allFib = new List <int> ();
            List <int> allEven = new List <int> ();
    
            for (i = 1; i < p; i = incr)
            {
                if ((i % 2) == 0)
                {
                    //allFib.Add(i);
                    allEven.Add(i);
                    incr = i + previous;
                    previous = i;
                    //i = i + previous;
                }
                else if (i > 0)
                {
                    //allFib.Add(i);
                    incr = i + previous;
                    previous = i;
                    //i = i + previous;
                }
            }
            foreach (var element in allEven)
            {
                print = print + element;
            }
            return print;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{

    // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91X99.
    // Find the largest palindromic made from the product of two 3-digit numbers.

    static class Problem4J
    {
        static public int ProblemJ4()
        { 

            int orderset = 1000;
            string testval = "1";
            int answerval = 0;
            bool passed = true;
            int Tvalue = 0;

            // Tracker for loop.
            int stat = 0;


            /*    VERSION 1
            while (passed)
                {
                // Find the value.
                
                
                int first = orderset - stat;
                int second = orderset - stat;

                // Value to check.
                Tvalue = first * second;

                // Check characters in value.
                string Tchar = Tvalue.ToString();
                List<int> Palin = new List<int>();
                List<char> Tlist = Tchar.ToCharArray().ToList();

                if (Tlist[0]== Tlist.Last())
                    {
                        if(Tlist[1]==(Tlist[4]))
                            {
                                if (Tlist[2] == (Tlist[3]))
                                {
                                    passed = false;
                                    Palin.Add(Tvalue);
                                }

                            }
                        else
                        {
                        stat++;
                        continue;

                        }
                    }
                
                // return true false.

                stat++;

            }
            */
            // VERSION 2
            int listlen = 0;
            int second = 0;
            List<int> Palin = new List<int>();
            while (passed)
            {
                for(stat=1; stat<orderset-1; stat++ )
                {
                    int first = orderset - stat;
                    Console.WriteLine("Current first number: " + first);
                    for (int sec = 1; sec<orderset; sec++)
                    {
                        second = orderset - sec;
                        Tvalue = first * second;
                        string Tchar = Tvalue.ToString();
                        listlen = Tchar.Count();
                        List<char> Tlist = Tchar.ToCharArray().ToList();
                        if (listlen > 5)
                        {
                            if (Tlist[0] == Tlist.Last())
                            {
                                if (Tlist[1] == (Tlist[listlen - 2]))
                                {
                                    if (Tlist[2] == (Tlist[listlen - 3]))
                                    {
                                        Palin.Add(Tvalue);
                                    }

                                }
                            }
                        }
                        else
                        {
                            sec = orderset - 1;
                        }
                        
                    }
                        }
                testval = Convert.ToString(Palin.Max());
                passed = false; 
            }
                
           
            answerval = Int32.Parse(testval);
            return answerval;
    }
    }
}

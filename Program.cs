using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Rud.Problem problem = new Rud.Problem5();
            // problem.Run();



            string answer = Problem8J.ProblemJ8();
            
            Console.WriteLine("Problem 1: " + answer);
            Console.ReadKey();
            /*
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //int answer = Problem1J.Class1();
            //int answer = Problem2J.ProblemJ2();
            //int answer = Problem3J.ProblemJ3();
            //int answer = Problem4J.ProblemJ4();
            




            watch.Stop();
            Console.WriteLine("Problem 1: " + answer);
            Console.WriteLine("Duration: " + watch.Elapsed);
            Console.ReadKey();
            */
        }
    }
}

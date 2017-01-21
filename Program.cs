using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //int answer = Problem1J.Class1();
            //int answer = Problem2J.ProblemJ2();
            int answer = Problem3J.ProblemJ3();

            watch.Stop();
            Console.WriteLine("Problem 1: " + answer);
            Console.WriteLine("Duration: " + watch.Elapsed);
            Console.ReadKey();
        }
    }
}

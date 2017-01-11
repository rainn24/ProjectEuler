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
            int answer = Problem1.Run();
            watch.Stop();
            Console.WriteLine("Problem 1: " + answer);
            Console.WriteLine("Duration: " + watch.Elapsed);
            Console.ReadKey();
        }
    }
}

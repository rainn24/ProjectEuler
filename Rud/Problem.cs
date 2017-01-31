using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectEuler.Rud
{
    class Problem
    {
        public string description;
        public string answer;
        Stopwatch watch;

        public void Run()
        {
            watch = new Stopwatch();
            watch.Start();
            Solve();
            watch.Stop();
            WriteResults();
            Console.WriteLine();
            Console.WriteLine("Duration (ticks): " + watch.ElapsedTicks);

            Console.WriteLine("Duration (ms): " + watch.ElapsedMilliseconds);            
        }

        public void Run(int count)
        {
            
            watch = new Stopwatch();

            long ticks = 0;
            long milliseconds = 0;

            WriteDescription();

            for (int i = 0; i < count; i++)
            {
                watch.Restart();
                Solve();
                watch.Stop();                
                ticks += watch.ElapsedTicks;
                milliseconds += watch.ElapsedMilliseconds;
                Console.Write(".");
            }
            Console.WriteLine();
            
            WriteResults();

            Console.WriteLine();
            Console.WriteLine("Average Duration of {0} runs (ticks): {1}", count, (double) ticks / count);
            Console.WriteLine("Average Duration of {0} runs (ms): {1}", count, (double) milliseconds / count);         
            Console.WriteLine();

        }

        void WriteDescription()
        {
            Console.WriteLine(this.GetType().Name);
            if (description != null)
            {
                var foo = description.Split('\n');
                Console.WriteLine(description);
            }
            Console.WriteLine("----------------------------------");
        }

        void WriteResults()
        {            
            if (answer != null)
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("No answer recorded");
            }
        }

        protected virtual void Solve()
        {
        }
    }
}

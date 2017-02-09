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

            WriteDescription();

            watch.Start();
            for (int i = 0; i < count; i++)
            {

                Solve();             
                
                Console.Write(".");
            }
            watch.Stop();   


            Console.WriteLine();
            
            WriteResults();

            Console.WriteLine();
            Console.WriteLine("Average Duration of {0} runs (ticks): {1}", count, watch.ElapsedTicks / count);
            Console.WriteLine("Average Duration of {0} runs (ms): {1}", count, watch.ElapsedMilliseconds/ count);         
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

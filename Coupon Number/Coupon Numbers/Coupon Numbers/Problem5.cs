using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace Problem5
{
    class Problem5
    {
        public static void StopWatch()
        {
            
            Console.WriteLine("Press Any One Key To Start StopWatch ");
            Console.ReadKey();


            Stopwatch timer = new Stopwatch();
            timer.Start();


            Console.WriteLine("\nPress Any One Key To End Stop Watch ");
            Console.ReadKey();
            timer.Stop();

            Console.WriteLine("\nStop at : {0} ",timer.Elapsed);
        }

        static void Main(String[] args)
        {
            StopWatch();
        }
    }
}

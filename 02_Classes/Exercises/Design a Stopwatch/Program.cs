using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                // the line below is to test if the start has been pressed twice it should give an error
                // stopwatch.Start();
                Thread.Sleep(2000);
                stopwatch.Stop();

                // this is to make sure the stopwatch can be used multiple times
                stopwatch.Start();
                Thread.Sleep(3000);
                stopwatch.Stop();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("You cannot start it again until you press stop");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();
        
        // Begin timing.
        stopwatch.Start();
        
        // Do something.
        for (int i = 0; i < 1000; i++) // less than thousand times this for loop has been iterated 
        {
            Thread.Sleep(1); // whenever cursor comes inside of the loop sleep function will run
        }
        
        // Stop timing.
        stopwatch.Stop();
        
        // Write result.
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed); // it will return elapsed time
        Console.ReadLine();
    }
}
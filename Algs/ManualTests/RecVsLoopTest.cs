using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Algs.Performance;

namespace Algs.ManualTests
{
    internal class RecVsLoopTest
    {
        internal void Invoke ()
        {
            int value;
            var test = new RecVsLoop();

            var watch = new Stopwatch();

            watch.Start();

            value = test.Loop(1000);

            watch.Stop();

            Console.WriteLine("x = {0} - Function called = Loop, Time taken = {1}", value, watch.ElapsedTicks);

            watch.Reset();
            watch.Start();

            value = test.Recursive(1000, 0);

            watch.Stop();

            Console.WriteLine("x = {0} - Function called = Recursive, Time taken = {1}", value, watch.ElapsedTicks);
        }
    }
}

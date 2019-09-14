using System;
using System.Diagnostics;
using Algs.ManualTests;
using Algs.Performance;
using Algs.Fibonacci;

namespace Algs
{
    class Program
    {
        static void Main (string[] args)
        {
			var FibMod = new FibMod(2816213588, 239);

            var answer = FibMod.Calculate();

            Console.WriteLine(answer);
        }
    }
}

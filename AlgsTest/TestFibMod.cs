using System;
using System.Collections.Generic;
using System.Text;
using Algs.Fibonacci;
using NUnit.Framework;

namespace AlgsTest
{
    [TestFixture]
    public class TestFibMod
    {
        FibMod Fib = new FibMod();

        [Test]
        public void TestFibModuloM ()
        {
            var First = Fib.CalculateFibModuloM(239, 1000);
            var Second = Fib.CalculateFibModuloM(2816213588, 239);

            Assert.IsTrue(First == 161 && Second == 151);
        }

        [Test]
        public void TestSumFibkMod10 ()
        {
            var First = Fib.CalculateSumFibkMod10(3);
            var Second = Fib.CalculateSumFibkMod10(100);

            Assert.IsTrue(First == 4 && Second == 5);
        }

        [Test]
        public void TestSumFibmTonMod10 ()
        {
            var First = Fib.CalculateSumFibmTonMod10(3, 7);
            var Second = Fib.CalculateSumFibmTonMod10(10, 10);
            var Third = Fib.CalculateSumFibmTonMod10(10, 200);

            Assert.IsTrue(First == 1 && Second == 5 && Third == 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Algs.MaxNoOfPrizes;
using NUnit.Framework;

namespace AlgsTest
{
    [TestFixture]
    public class TestNoOfPrizes
    {
        public void TestPrizes ()
        {
            var candies = new Candies();

            var prizes = candies.NoOfPrizes(8);

            Assert.IsTrue(prizes[0] == 1 && prizes[1] == 2 && prizes[2] == 5);
        }
    }
}

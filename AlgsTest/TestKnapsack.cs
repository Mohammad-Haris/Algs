using Algs.FractionalKnapsack;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlgsTest
{
    [TestFixture]
    public class TestKnapsack
    {
        [Test]
        public void GreedyThief ()
        {
            var thief = new GreedyThief();

            var LootOne = new LootModel(3, 50, new List<Loot>()
            {
                new Loot(60, 20),
                new Loot(100, 50),
                new Loot(120, 30)
            });

            var GreedyLootOne = thief.GetLoot(LootOne);

            var LootSecond = new LootModel(1, 10, new List<Loot>()
            {
                new Loot(500, 30)
            });

            var GreedyLootSecond = thief.GetLoot(LootSecond);

            Assert.IsTrue(GreedyLootOne == 180 && GreedyLootSecond == (decimal)166.6667);
        }
    }
}

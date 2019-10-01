using System;
using System.Collections.Generic;

namespace Algs.FractionalKnapsack
{
    public class LootModel
    {
        public int NoOfLoot
        {
            get; private set;
        }

        public int KnapsackCapacity
        {
            get; set;
        }

        public List<Loot> _Loot
        {
            get; private set;
        }

        public LootModel (int n, int w, List<Loot> loot)
        {
            NoOfLoot = n;
            KnapsackCapacity = w;

            if (loot.Count == n)
            {
                _Loot = loot;
            }

            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public class Loot
    {
        public Loot (int amount, int weight)
        {
            Amount = amount;
            Weight = weight;
            Value = amount / weight;
        }

        public int Amount
        {
            get; set;
        }

        public int Weight
        {
            get; set;
        }

        public decimal Value
        {
            get; set;
        }
    }
}

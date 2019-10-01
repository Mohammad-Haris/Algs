using System;
using System.Linq;

namespace Algs.FractionalKnapsack
{
    public class GreedyThief
    {
        public decimal GetLoot (LootModel Loot)
        {
            decimal LootSum = 0;

            while(Loot.KnapsackCapacity > 0)
            {
                var Max = Loot._Loot.OrderByDescending(l => l.Value).First();

                if (Max.Weight <= Loot.KnapsackCapacity)
                {
                    LootSum += Max.Amount;
                    Loot.KnapsackCapacity -= Max.Weight;
                    Max.Weight = 0;
                    Max.Amount = 0;
                    Max.Value = 0;
                }

                else
                {
                    LootSum += ((decimal)Max.Amount / (decimal.Divide(Max.Weight, Loot.KnapsackCapacity)));
                    Loot.KnapsackCapacity = 0;
                    break;
                }                
            }

            return Math.Round(LootSum, 4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algs.MaxNoOfPrizes
{
    public class Candies
    {
        public List<int> NoOfPrizes (int candies)
        {
            var prizes = new List<int>();

            int i = 0;
            prizes.Add(1);
            candies--;

            while (candies > prizes[i])
            {
                prizes.Add(i + 2);
                candies -= (i + 2);
                i++;
            }

            prizes[prizes.Count - 1] += candies;

            return prizes;
        }
    }
}

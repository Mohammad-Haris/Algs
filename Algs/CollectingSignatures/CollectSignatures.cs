using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algs.CollectingSignatures
{
    public class CollectSignatures
    {
        public List<int> CommonTime (List<int[]> ClientDetails)
        {
            var OrderedDetails = ClientDetails.OrderByDescending(d => d[0]);

            List<int> CommonPoints = new List<int>();

            CommonPoints.Add(OrderedDetails.First()[0]);

            var i = 0;
            foreach (var detail in OrderedDetails)
            {
                if (CommonPoints[i] > detail[1])
                {
                    CommonPoints.Add(detail[0]);
                    i++;
                }
            }

            return CommonPoints;
        }
    }
}

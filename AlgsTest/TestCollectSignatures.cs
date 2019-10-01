using System;
using System.Collections.Generic;
using System.Text;
using Algs.CollectingSignatures;
using NUnit.Framework;

namespace AlgsTest
{
    [TestFixture]
    public class TestCollectSignatures
    {
        [Test]
        public void TestCommonPoints ()
        {
            var clients = new CollectSignatures();

            var times = clients.CommonTime(new List<int[]>
            {
                new int[] {1, 1000},
                new int[] {2, 199},
                new int[] {3, 49},
                new int[] {60, 70}

            });

            times.AddRange(clients.CommonTime(new List<int[]>
            {
                new int[] {4, 7},
                new int[] {1, 3},
                new int[] {2, 5},
                new int[] {5, 6}

            }));

            times.AddRange(clients.CommonTime(new List<int[]>
            {
                new int[] {1, 3},
                new int[] {2, 5},
                new int[] {3, 6}

            }));

            Assert.IsTrue(times[0] == 60 && times[1] == 3 && times[2] == 5 && times[3] == 1 && times[4] == 3);
        }
    }
}

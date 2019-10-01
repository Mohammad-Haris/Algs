using Algs.MaxSalary;
using NUnit.Framework;

namespace AlgsTest
{
    [TestFixture]
    public class TestMaxSalary
    {
        [Test]
        public void TestGetMax ()
        {
            var salary = new Salary();

            var max = salary.GetMax(new int[] { 9, 4, 6, 1, 9 });

            Assert.IsTrue(max == "99641");
        }
    }
}

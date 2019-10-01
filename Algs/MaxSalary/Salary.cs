using System.Linq;
using System.Text;

namespace Algs.MaxSalary
{
    public class Salary
    {
        public string GetMax (int[] numbers)
        {
            StringBuilder NS = new StringBuilder();

            foreach (var num in numbers)
            {
                NS.Append(num.ToString());
            }

            var NumberString = NS.ToString();

            var NumberChars = NumberString.ToCharArray();

            var OrderedNumbers =  NumberChars.OrderByDescending(c => (int)c);

            var max = new StringBuilder();

            foreach (var num in OrderedNumbers)
            {
                max.Append(num);
            }

            return max.ToString();
        }
    }
}

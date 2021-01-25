using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IEnumerable.Utils
{
    public static class NumberUtils
    {
        public static IEnumerable<int> GetValues()
        {
            yield return 13;
            yield return 42;
            yield return -9;
        }

        public static IEnumerable<int> GetEven(int minValue = 0, int maxValue = 10)
        {
            int current = minValue;

            while(current <= maxValue)
            {
                yield return current;

                current += 2;
            }
        }

    }
}

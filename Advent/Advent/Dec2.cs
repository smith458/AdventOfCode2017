using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec2
    {
        public static int CheckSum(Array arr)
        {
            int sum = 0;

            foreach (int[] intArr in arr)
            {
                sum += intArr.Max() - intArr.Min();
            }

            return sum;
        }

        public static int CheckSumDiv(Array arr)
        {
            int sum = 0;

            foreach (int[] intArr in arr)
            {
                sum += LookForDiv(intArr);
            }

            return sum;
        }

        public static int LookForDiv(int[] arr)
        {
            for (int x = 0; x < arr.Length; ++x)
            {
                for (int y = 0; y < arr.Length; ++y)
                {
                    if (arr[x] % arr[y] == 0 && x != y)
                    {
                        return arr[x] / arr[y];
                    }
                }
            }

            return 0;
        }
    }
}

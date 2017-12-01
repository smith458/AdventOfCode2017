using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec1
    {
        public static int SumMatchDig(string intStr)
        {
            int sum = 0;

            for (int i = 0; i < intStr.Length; i++)
            {
                int n = (i + 1 == intStr.Length) ? 0 : i + 1;

                if (intStr[i] == intStr[n])
                {
                    sum += int.Parse(intStr[i].ToString());
                }
            }

            return sum;
        }

        public static int SumSkipDig(string intStr)
        {
            int sum = 0;

            for (int i = 0; i < intStr.Length; i++)
            {
                int skip = intStr.Length / 2;
                int n = (i + skip >= intStr.Length) ? i + skip - intStr.Length : i + skip;

                if (intStr[i] == intStr[n])
                {
                    sum += int.Parse(intStr[i].ToString());
                }
            }

            return sum;
        }
    }
}

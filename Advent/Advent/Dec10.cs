using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec10
    {
        public static int KnotHashCheck(int len, int[] input)
        {
            int[] start = new int[len];

            for (int i = 0; i < start.Length; i++)
            {
                start[i] = i;
            }

            int skip = 0;
            int pos = 0;

            foreach (int step in input)
            {
                start = ReverseSection(start, pos, step);
                pos = pos + step + skip;

                if (pos >= len)
                {
                    pos = pos - len;
                }

                skip++;
            }


            return start[0] * start[1];
        }

        public static int[] ReverseSection(int[] arr, int begin, int len)
        {
            int[] rev;

            if (begin + len < arr.Length)
            {
                rev = arr.Skip(begin).Take(len).Reverse().ToArray();
            }
            else
            {
                rev = new int[len];

                for (int x = 0; x < len; x++)
                {
                    int index = (begin + x) < arr.Length ? begin + x : begin + x - arr.Length;
                    rev[x] = arr[index];
                }

                rev = rev.Reverse().ToArray();
            }
            
            for (int x = 0; x < rev.Length; x++)
            {
                int index = (begin + x) < arr.Length ? begin + x : begin + x - arr.Length;
                arr[index] = rev[x];
            }

            return arr;
        }
    }
}

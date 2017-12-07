using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec6
    {
        public static int CountReallocations(int[] arr)
        {
            Dictionary<string, int> history = new Dictionary<string, int>();

            int count = 0;
            string outStr;
            history.Add(ArrToStr(arr), count);

            while (true)
            {
                arr = ReallocateBlocks(arr);
                count++;
                outStr = ArrToStr(arr);

                if (!history.ContainsKey(outStr))
                {
                    history.Add(outStr, count);
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        public static int CountReallocations(string[] arr)
        {
            return CountReallocations(General.StrArrToIntArr(arr));
        }

        public static int CountLoopLength(int[] arr)
        {
            Dictionary<string, int> history = new Dictionary<string, int>();
            int count = 0;
            string outStr;
            history.Add(ArrToStr(arr), count);

            while (true)
            {
                arr = ReallocateBlocks(arr);
                count++;
                outStr = ArrToStr(arr);

                if (!history.ContainsKey(outStr))
                {
                    history.Add(outStr, count);
                }
                else
                {
                    break;
                }
            }

            return count - history[outStr];
        }

        private static int[] ReallocateBlocks(int[] arr)
        {
            int max = arr.Max();
            int index = Array.IndexOf(arr, max);
            arr[index] = 0;

            for (int x = 1; x <= max; ++x)
            {
                index++;
                if (index >= arr.Length)
                {
                    index = 0;
                }
                arr[index]++;
            }

            return arr;
        }

        private static string ArrToStr(int[] arr)
        {
            string outStr = "";

            foreach (int item in arr)
            {
                outStr += item.ToString();
                outStr += ", ";
            }

            return outStr;
        }
    }
}

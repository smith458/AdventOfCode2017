using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public static class General
    {
        public static int[] StrArrToIntArr(string[] arr)
        {
            int[] intArr = new int[arr.Length];

            for (int x = 0; x < arr.Length; x++)
            {
                intArr[x] = int.Parse(arr[x]);
            }

            return intArr;
        }
    }
}

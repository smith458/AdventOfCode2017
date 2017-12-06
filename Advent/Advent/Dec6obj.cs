using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec6obj
    {
        private int[] _banks;
        Dictionary<string, int> history = new Dictionary<string, int>();

        public Dec6obj(int[] banks)
        {
            _banks = banks;
        }

        public Dec6obj(string[] banks)
        {
            _banks = General.StrArrToIntArr(banks);
        }

        public int CountReallocations()
        {
            int count = 0;
            string outStr;
            history.Add(ArrToStr(), count);

            while (true)
            {
                ReallocateBlocks();
                count++;
                outStr = ArrToStr();

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

        public int CountLoopLength()
        {
            int count = 0;
            string outStr;
            history.Add(ArrToStr(), count);

            while (true)
            {
                ReallocateBlocks();
                count++;
                outStr = ArrToStr();

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

        private void ReallocateBlocks()
        {
            int max = _banks.Max();
            int index = Array.IndexOf(_banks, max);
            _banks[index] = 0;

            for (int x = 1; x <= max ; ++x)
            {
                index++;
                if (index >= _banks.Length)
                {
                    index = 0;
                }
                _banks[index]++;
            }
        }

        private string ArrToStr()
        {
            string outStr = "";

            foreach (int item in _banks)
            {
                outStr += item.ToString();
                outStr += ", ";
            }

            return outStr;
        }
    }
}

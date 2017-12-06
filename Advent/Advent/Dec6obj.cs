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
        HashSet<string> history = new HashSet<string>();

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
            bool unique = true;
            int count = 0;
            Store();

            while (unique)
            {
                ReallocateBlocks();
                count++;
                unique = Store();
            }

            return count;
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

        private bool Store()
        {
            string outStr = "";

            foreach (int item in _banks)
            {
                outStr += item.ToString();
                outStr += ", ";
            }

            return history.Add(outStr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec5
    {
        public static int CountArraySteps(int[] steps)
        {
            int index = 0;      //Current index
            int totalSteps = 0; //Total steps taken

            while (index >= 0 && index < steps.Length)
            {
                index += steps[index]++; //Move and then increment the index after we move
                totalSteps++;
            }

            return totalSteps;
        }
    }
}

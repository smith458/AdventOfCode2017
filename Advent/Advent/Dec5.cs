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

        public static int CountArraySteps(string[] steps)
        {
            int[] intSteps = new int[steps.Length];

            for (int x = 0; x < steps.Length; x++)
            {
                intSteps[x] = int.Parse(steps[x]);
            }

            return CountArraySteps(intSteps);
        }

        public static int CountArrayStrangeSteps(int[] steps)
        {
            int index = 0;      //Current index
            int totalSteps = 0; //Total steps taken
            int hold = 0;      //Holds index for incrementing/decrementing

            while (index >= 0 && index < steps.Length)
            {
                hold = index;
                index += steps[index]; //Move and then increment the index after we move
                totalSteps++;
                if (steps[hold] >= 3)
                {
                    --steps[hold];
                }
                else
                {
                    ++steps[hold];
                }
            }

            return totalSteps;
        }

        public static int CountArrayStrangeSteps(string[] steps)
        {
            int[] intSteps = new int[steps.Length];

            for (int x = 0; x < steps.Length; x++)
            {
                intSteps[x] = int.Parse(steps[x]);
            }

            return CountArrayStrangeSteps(intSteps);
        }
    }
}

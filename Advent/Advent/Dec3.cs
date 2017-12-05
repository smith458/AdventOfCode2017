using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec3
    {
        public static int FindSteps(int loc)
        {
            //Size and tier variables
            int nearestSquare = (int) Math.Ceiling(Math.Sqrt(loc));                 //Finds nearest perfect square
            int width = nearestSquare % 2 == 1 ? nearestSquare : nearestSquare + 1; //Always pushes to odd squares because width increments by two every tier
            int tier = (int) Math.Ceiling(width / 2.0);                             //Finds tier of the location

            //Move variables
            int minMoves = tier - 1;                                                //Minimum number of moves to get to center (middle of side case)
            int maxMoves = minMoves * 2;                                            //Maximum number of moves to get to center (corner case)

            //Corner variables
            int tierMax = (int) Math.Pow(width, 2);                                 //Largest value in current tier
            int cornerAbove = 0;
            int cornerBelow = 0;

            //Calculates the corners of this tier and saves the corner directly above and below the location
            //Returns the max value if the location is a corner
            for (int x = 0; x < 4; ++x)
            {
                int corner = tierMax - (x * (width - 1));
                if (corner > loc)
                {
                    cornerAbove = corner;
                }
                else if (corner < loc)
                {
                    cornerBelow = corner;
                    break;
                }
                else
                {
                    return maxMoves;
                }
            }

            //Number of steps away from corner
            int stepsToCorner = Math.Min(cornerAbove - loc, loc - cornerBelow);

            //The location is closer to the center than the corner
            return maxMoves - stepsToCorner;
        }

        public static int FindNearestSumSteps(int val)
        {
            return 0;
        }
    }
}

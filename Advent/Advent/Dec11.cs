using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec11
    {
        public static int CountSteps(string[] arr)
        {
            Dictionary<string, int> steps = new Dictionary<string, int>();

            foreach (string dir in arr)
            {
                if (steps.ContainsKey(dir))
                {
                    steps[dir]++;
                }
                else
                {
                    steps.Add(dir, 0);
                }
            }

            double n = steps["n"] + steps["ne"] * .5 + steps["nw"] * .5;
            double s = steps["s"] + steps["se"] * .5 + steps["sw"] * .5;
            double e = steps["ne"] + steps["se"];
            double w = steps["nw"] + steps["sw"];

            int horizontal = (int) Math.Abs( e - w);
            int vertical = (int)(n - s - horizontal / 2);
            return horizontal + vertical;
        }

        public static int CountFarthest(string[] arr)
        {
            Dictionary<string, int> steps = new Dictionary<string, int>();
            steps.Add("n" , 0);
            steps.Add("s" , 0);
            steps.Add("ne", 0);
            steps.Add("se", 0);
            steps.Add("nw", 0);
            steps.Add("sw", 0);

            int farthest = 0;
            foreach (string dir in arr)
            {
                steps[dir]++;

                double n = steps["n"] + steps["ne"] * .5 + steps["nw"] * .5;
                double s = steps["s"] + steps["se"] * .5 + steps["sw"] * .5;
                double e = steps["ne"] + steps["se"];
                double w = steps["nw"] + steps["sw"];

                int horizontal = (int)Math.Abs(e - w);
                int vertical = (int)(n - s - horizontal / 2);
                int distance = horizontal + vertical;

                farthest = Math.Max(distance, farthest);
            }

            return farthest;
        }
    }
}

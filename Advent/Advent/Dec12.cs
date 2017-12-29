using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Advent
{
    public class Dec12
    {
        //Grabs left value, the number in the group that contains the id
        public static int CountInGroup(string[] arr, int id)
        {
            return CountInGroupAndGroups(arr, id).Item1;
        }

        //Grabs the right value, the number of total groups
        public static int CountGroups(string[] arr)
        {
            return CountInGroupAndGroups(arr).Item2;
        }

        //Returns LEFT Number in group with ID and RIGHT number of groups
        internal static Tuple<int, int> CountInGroupAndGroups(string[] arr, int id=0)
        {
            string regExStr = @"^(\d*)\s<->\s(.*)";
            List<HashSet<int>> setList = new List<HashSet<int>>();

            foreach (string line in arr)
            {
                Match match = Regex.Match(line, regExStr);
                string[] nums = match.Groups[2].Value.Split(new string[] { ", " }, StringSplitOptions.None);
                List<int> intList = nums.Select(x => int.Parse(x)).ToList();
                intList.Add(int.Parse(match.Groups[1].Value));
                
                foreach (Group num in match.Groups)
                {
                    if (int.TryParse(num.Value, out int val))
                    {
                        intList.Add(val);
                    }
                }

                bool containsOne = false; //Checks to see if any of the sets contain on of the numbers

                foreach (HashSet<int> set in setList)
                {
                    if (set.Intersect<int>(intList).Count<int>() > 0)
                    {
                        containsOne = true;
                    }

                    if (containsOne)
                    {
                        set.UnionWith(intList);
                        break;
                    }
                }

                if (!containsOne)
                {
                    setList.Add(new HashSet<int>(intList));
                }
            }

            int changes;

            do
            {
                changes = 0;

                for (int a = 0; a < setList.Count; a++)
                {
                    for (int b = 0; b < setList.Count; b++)
                    {
                        if (setList[a].Intersect<int>(setList[b]).Count<int>() > 0 && a != b)
                        {
                            setList[a].UnionWith(setList[b]);
                            setList.RemoveAt(b);
                            changes++;
                        }
                    }
                }
            } while (changes > 0);

            int count = 0;

            foreach (HashSet<int> set in setList)
            {
                if (set.Contains(id))
                {
                    count = set.Count;
                    break;
                }
            }

            return Tuple.Create(count, setList.Count);
        }
    }
}

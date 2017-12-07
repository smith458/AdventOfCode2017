using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec7
    {
        public static string FindHead(string[] lineArr)
        {
            HashSet<string> parSet = new HashSet<string>();
            HashSet<string> childSet = new HashSet<string>();

            foreach (string line in lineArr)
            {
                string[] halves = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                parSet.Add(halves[0].Split(' ')[0]);
                if (halves.Length > 1)
                {
                    string[] children = halves[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string child in children)
                    {
                        childSet.Add(child);
                    }
                }
            }

            return parSet.Except(childSet).ToArray()[0];
        }
    }
}

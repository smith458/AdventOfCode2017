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

        public static int FindWrongWeight(string[] lineArr)
        {
            string head = FindHead(lineArr);
            string headLine = lineArr.FirstOrDefault(x => (string) x.Take(head.Length) == head);

            return 0;
        }

        public static object[] LineParser(string line)
        {
            string[] halves = line.Split(" -> ", StringSplitOptions.None);
            
        }
    }

    public class TreeNode
    {
        string _name;
        int _weight;
        List<TreeNode> _children = null;


        public TreeNode(string name, int weight, string[] data, string[] children = null)
        {
            _name = name;
            _weight = weight;

            if (children != null)
            {
                foreach (string child in children)
                {
                    _children.Add(CreateTreeNode(child));
                }
            }
        }

        internal TreeNode CreateTreeNode(string child)
        {
            return new TreeNode("", 1, new string[0]);
        }
    }
        
}

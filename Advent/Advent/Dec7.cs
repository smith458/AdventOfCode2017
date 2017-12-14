using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

    //Pass the whole line array and returns the head
    public class TreeCreator
    {
        string[] _lines;
        TreeNode _headNode;

        public TreeCreator(string[] lines, string head)
        {
            _lines = lines;
            _headNode = CreateNode(head);
        }

        public TreeNode CreateNode(string name)
        {
            string line = _lines.FirstOrDefault(x => x.StartsWith(name));
            TreeNode node = new TreeNode(line);
            foreach (string child in node.Children)
            {
                node.ChildNodes.Add(CreateNode(child));
            }

            return node;
        }

        public int FindOffWeight()
        {
            return CheckWeight(_headNode);
        }

        private int CheckWeight(TreeNode node)
        {
            int outVal = -1;

            if (node.ChildNodes.Count > 0)
            {
                List<int> weightList = new List<int>();

                foreach (TreeNode child in node.ChildNodes)
                {
                    weightList.Add(child.TotalWeight);
                }

                int index = FindUnique(weightList);
                
                if (index >= 0)
                {
                    outVal = CheckWeight(node.ChildNodes[index]);
                    if (outVal < 0)
                    {
                        int otherIndex = index == 0 ? 1 : 0;
                        int nomWeight = node.ChildNodes[otherIndex].TotalWeight;
                        int curWeight = node.ChildNodes[index].TotalWeight;
                        outVal = node.ChildNodes[index].Weight + (nomWeight - curWeight);
                    }
                }
            }

            return outVal;
        }

        //Finds the Unique item and returns the index or returns -1 if all values are equal
        private int FindUnique(List<int> col)
        {
            int index = -1;

            for (int i = 0; i < col.Count(); ++i)
            {
                //Count number of occurences of Item
                int itemCount = col.Count(x => x == col[i]);

                //See if every item in the list is Item
                if (itemCount != col.Count())
                {
                    //If not, see if item is the only occurence and return it
                    if (itemCount == 1)
                    {
                        index = i;
                    }

                }
            }

            return index;
        }
    }

    public class TreeNode
    {
        public string Name;
        public int Weight;
        public int TotalWeight
        {
            get
            {
                int sum = Weight;
                if (ChildNodes.Count > 0)
                {
                    foreach (TreeNode child in ChildNodes)
                    {
                        sum += child.TotalWeight;
                    }
                }
                return sum;
            }
        }

        public string[] Children;
        public List<TreeNode> ChildNodes = new List<TreeNode>();

        public TreeNode(string line)
        {
            Match match = Regex.Match(line, @"^([^\s]+)\s\(([\d]+)\)[\s->]*(.*)");

            Name = match.Groups[1].Value;
            Weight = int.Parse(match.Groups[2].Value);
            Children = match.Groups[3].Value.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
        
}

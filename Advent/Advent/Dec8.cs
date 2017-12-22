using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Advent
{
    public class Dec8
    {
        public static int ProcessInstructions(string[] arr)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in arr)
            {
                Match match = Regex.Match(item, @"^([^\s]*)\s([^\s]*)\s([^\s]*)\s[^\s]*\s([^\s]*)\s([^\s]*)\s([^\s]*)");
                string opKey = match.Groups[1].ToString();
                string op = match.Groups[2].ToString();
                int opVal = int.Parse(match.Groups[3].ToString());
                string compKey = match.Groups[4].ToString();
                string comp = match.Groups[5].ToString();
                int compVal = int.Parse(match.Groups[6].ToString());

                if (!dict.ContainsKey(opKey))
                {
                    dict.Add(opKey, 0);
                }

                if (!dict.ContainsKey(compKey))
                {
                    dict.Add(compKey, 0);
                }

                if (EvaluateCompare(dict[compKey], comp, compVal))
                {
                    dict[opKey] = ProcessOperation(dict[opKey], op, opVal);
                }
            }

            return dict.Values.Max();
        }

        public static int MaxDuringProcessInstructions(string[] arr)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int max = 0;

            foreach (var item in arr)
            {
                Match match = Regex.Match(item, @"^([^\s]*)\s([^\s]*)\s([^\s]*)\s[^\s]*\s([^\s]*)\s([^\s]*)\s([^\s]*)");
                string opKey = match.Groups[1].ToString();
                string op = match.Groups[2].ToString();
                int opVal = int.Parse(match.Groups[3].ToString());
                string compKey = match.Groups[4].ToString();
                string comp = match.Groups[5].ToString();
                int compVal = int.Parse(match.Groups[6].ToString());

                if (!dict.ContainsKey(opKey))
                {
                    dict.Add(opKey, 0);
                }

                if (!dict.ContainsKey(compKey))
                {
                    dict.Add(compKey, 0);
                }

                if (EvaluateCompare(dict[compKey], comp, compVal))
                {
                    dict[opKey] = ProcessOperation(dict[opKey], op, opVal);
                    max = Math.Max(max, dict[opKey]);
                }
            }

            return max;
        }

        public static bool EvaluateCompare(int a, string comp, int b)
        {
            bool result;

            switch (comp)
            {
                case "==":
                    result = a == b;
                    break;
                case ">":
                    result = a > b;
                    break;
                case ">=":
                    result = a >= b;
                    break;
                case "<":
                    result = a < b;
                    break;
                case "<=":
                    result = a <= b;
                    break;
                case "!=":
                    result = a != b;
                    break;
                default:
                    throw new ArgumentException($"Unimplemented Comparator: {comp}");
            }

            return result;
        }

        public static int ProcessOperation(int a, string op, int b)
        {
            int result;

            switch (op)
            {
                case "inc":
                    result = a + b;
                    break;
                case "dec":
                    result = a - b;
                    break;
                default:
                    throw new ArgumentException($"Unimplemented Operator: {op}");
            }

            return result;
        }
    }
}

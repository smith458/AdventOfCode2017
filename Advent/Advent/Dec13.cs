using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Advent
{
    public class Dec13
    {
        public static int? CountSeverity(string[] arr, int delay = 0)
        {
            string regExPattern = @"(\d+):\s(\d+)";
            int maxDepth = 0;

            foreach (string row in arr)
            {
                Match match = Regex.Match(row, regExPattern);
                int depth = int.Parse(match.Groups[1].ToString());
                if (depth > maxDepth)
                {
                    maxDepth = depth+1;
                }
            }

            Scanner[] scanners = new Scanner[maxDepth];

            int? severity = null;

            foreach (string row in arr)
            {
                Match match = Regex.Match(row, regExPattern);
                int depth = int.Parse(match.Groups[1].ToString());
                int range = int.Parse(match.Groups[2].ToString());
                scanners[depth] = new Scanner(range);
            }

            for (int i = 0; i < delay; i++)
            {
                foreach (Scanner scanner in scanners)
                {
                    if (scanner != null)
                    {
                        scanner.updatePosition();
                    }
                }
            }

            for (int i = 0; i < scanners.Length; i++)
            {
                if (scanners[i] != null)
                {
                    if (scanners[i].Position == 1)
                    {
                        severity = (severity == null) ? i * scanners[i].Range : severity + i * scanners[i].Range;
                    }
                }

                foreach (Scanner scanner in scanners)
                {
                    if (scanner != null)
                    {
                        scanner.updatePosition();
                    }
                }
            }

            return severity;
        }

        /*
        public static int CalculateDelay(string[] arr)
        {
            int delay = -1;
            int? severity = 0;

            do
            {
                ++delay;
                Console.WriteLine(delay);
                severity = CountSeverity(arr, delay);
            } while (severity != null);

            return delay;
        }
        */

        public static int CalculateDelay(string[] arr)
        {
            string regExPattern = @"(\d+):\s(\d+)";
            int maxDepth = 0;

            foreach (string row in arr)
            {
                Match match = Regex.Match(row, regExPattern);
                int depth = int.Parse(match.Groups[1].ToString());
                if (depth > maxDepth)
                {
                    maxDepth = depth + 1;
                }
            }

            Scanner[] scanners = new Scanner[maxDepth];

            foreach (string row in arr)
            {
                Match match = Regex.Match(row, regExPattern);
                int depth = int.Parse(match.Groups[1].ToString());
                int range = int.Parse(match.Groups[2].ToString());
                scanners[depth] = new Scanner(range);
            }

            int delay = -1;
            bool caught = true;
            Scanner[] newArr = new Scanner[maxDepth];

            do
            {
                delay++;
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = (scanners[i] == null) ? null : scanners[i].Clone();
                }
                caught = CheckForCaught(newArr);
                foreach (Scanner scanner in scanners)
                {
                    if (scanner != null)
                    {
                        scanner.updatePosition();
                    }
                }
                Console.WriteLine(delay);

            } while (caught);

            return delay;
        }

        public static bool CheckForCaught(Scanner[] scanners)
        {
            bool caught = false;

            for (int i = 0; i < scanners.Length; i++)
            {
                if (scanners[i] != null)
                {
                    if (scanners[i].Position == 1)
                    {
                        caught = true;
                        break;
                    }
                }

                foreach (Scanner scanner in scanners)
                {
                    if (scanner != null)
                    {
                        scanner.updatePosition();
                    }
                }
            }

            return caught;
        }
    }

    

    

    public class Scanner
    {
        public int Position;
        public int Range;
        public int Velocity;
        private bool atMax
        {
            get
            {
                return ((Position + Velocity) > Range || (Position + Velocity) < 1) ? true : false;
            }
        }

        public Scanner(int range)
        {
            Position = 1;
            Range = range;
            Velocity = 1;
        }

        public void updatePosition()
        {
            Position += Velocity;
            if (atMax)
            {
                Velocity *= -1;
            }
        }

        public Scanner Clone()
        {
            Scanner newScanner = new Scanner(Range);
            newScanner.Position = Position;
            newScanner.Velocity = Velocity;
            return newScanner;
        }
    }
}

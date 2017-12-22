using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec9
    {
        public static int ScoreGroups(string line)
        {
            char[] lineArr = line.ToCharArray();
            bool isJunk = false;

            int level = 0;
            int score = 0;

            for (int x = 0; x < lineArr.Length; x++)
            {
                if (lineArr[x] == '!')
                {
                    lineArr[x] = ' ';
                    lineArr[x + 1] = ' ';
                }

                if (!isJunk)
                {
                    switch (lineArr[x])
                    {
                        case '<':
                            isJunk = true;
                            break;
                        case '{':
                            level++;
                            break;
                        case '}':
                            score += level--;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    if (lineArr[x] == '>')
                    {
                        isJunk = false;
                    }
                }
            }

            return score;
        }

        public static int CountCancelled(string line)
        {
            char[] lineArr = line.ToCharArray();
            bool isJunk = false;
            int count = 0;

            for (int x = 0; x < lineArr.Length; x++)
            {
                if (lineArr[x] == '!')
                {
                    lineArr[x] = ' ';
                    lineArr[x + 1] = ' ';

                    if (isJunk)
                    {
                        count -= 2;
                    }
                }

                if (!isJunk)
                {
                    if (lineArr[x] == '<')
                    {
                        isJunk = true;
                    }
                }
                else
                {
                    if (lineArr[x] == '>')
                    {
                        isJunk = false;
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

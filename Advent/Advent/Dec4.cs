using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec4
    {
        public static int CountLegalPass(string[] phrases)
        {
            int legalCount = 0;
            int lineCount = 0;

            foreach (string phrase in phrases)
            {
                lineCount++;
                string[] words = phrase.Split(' ');
                HashSet<string> set = new HashSet<string>();

                foreach (string word in words)
                {
                    set.Add(word);
                }

                if (words.Length == set.Count)
                {
                    legalCount++;
                }
            }

            return legalCount;
        }

        public static int CountNoAnaPass(string[] phrases)
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class Dec4
    {
        public delegate bool ComparisonFunc(string a, string b);

        public static int CountLegalPass(string[] phrases)
        {
            int legalCount = 0;

            foreach (string phrase in phrases)
            {
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
            int legalCount = 0;

            foreach (string phrase in phrases)
            {
                string[] words = phrase.Split(' ');

                //Count comparisons returns 0 if no anagrams were found
                if (CountComparisonTruesInArray(words, CheckWordsForAna) == 0)
                {
                    legalCount++;
                }
            }

            return legalCount;
        }

        //Checks words to see if there are no anagrams. True means there are anagrams. False means none were found.
        private static bool CheckWordsForAna(string a, string b)
        {
            string c = a + b;

            foreach (char item in c)
            {
                int countA = a.Count(x => x == item);
                int countB = b.Count(x => x == item);

                if (countA != countB)
                {
                    return false;
                }
            }

            return true;
        }

        //Compares all the words in an array. Returns number of times comparison was true.
        private static int CountComparisonTruesInArray(string[] words, ComparisonFunc comp)
        {
            int count = 0;
            
            //x is the word it is comparing. Starts at the front of the list and counts to the second to last
            for (int x = 0; x < words.Length - 1; x++)
            {
                //y is the word x is being compared against. Starts one after x and moves to the end of the list
                for (int y = x + 1; y < words.Length; y++)
                {
                    //Only words of the same length can be anagrams
                    if (words[x].Length == words[y].Length)
                    {
                        //Check to see if the two words are anagrams
                        if (comp(words[x], words[y]))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }
    }
}

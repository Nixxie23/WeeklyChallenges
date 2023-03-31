using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool answer = false;
            if (words == null || words.Count() == 0)
            {
                return false;
            }
                       
                foreach (string posMatch in words)
                {
                if (posMatch == null)
                {
                    continue;
                }
                    if (posMatch.ToLower() == word.ToLower() && ignoreCase == true)
                    {
                        answer = true;
                    }
                    else if (posMatch == word)
                {
                    answer = true; 
                }
                }
                return answer;
            
        }

        public bool IsPrimeNumber(int num)
        {
            bool isAPrime = true;
            if (num < 2)
            {
                return false;
            }
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    isAPrime = false;
                }
            }
            return isAPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            var uniqueList = new List<char>();

            foreach (char letter in str)
            {
                int counter = 0;
                    for (int x = 0; x < str.Length;x++) 
                {
                    if (letter == str[x])
                    {
                        counter++; 
                    }
                }

                if (counter == 1)
                {
                    uniqueList.Add(letter);   
                }
            }

            uniqueList.ToArray();

            if (uniqueList.Count == 0)
            {
                return -1;
            }
            else
            return str.IndexOf(uniqueList[uniqueList.Count - 1]);

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
                      
            int winner = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 1;
                for (int x = i + 1; x < numbers.Length; x++)
                {
                    if (numbers[i] != numbers[x])
                    {
                        break;
                    }
                    counter++;
                }
                if (counter > winner)
                {
                    winner = counter;
                }
            }
            return winner;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var numHolder = new List<double>();
            if (elements == null || elements.Count() == 0 || n < 1) 
            {
                return new double[] { };
            }
            for(int i = n-1; i < elements.Count(); i += n) 
            {
                numHolder.Add(elements[i]);
            }
            return numHolder.ToArray();
         }
    }
}

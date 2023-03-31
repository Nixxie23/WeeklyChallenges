using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int answer = startNumber;
            if (startNumber % n == 0)
            {
                answer = startNumber + n;
            }
            else
            {
                for (int x = startNumber + n; x % n != 0; x++)
                {
                    answer += 1;
                }
            }
            return answer;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }

            }   
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool result = true;
            if(numbers == null)
            {
                return false;
            }
            else if (numbers.Length == 0)
            {
                return false;
            }
           for (int i = 0; i < numbers.Length - 1 && result == true; i++)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    result = true;
                }
                else
                    result = false;
                   
            }
           return result;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sumAfterEvens = 0;
            for (int i = 0; i < numbers.Length - 1;  i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    sumAfterEvens += numbers[i + 1];
                }
                
            }
            return sumAfterEvens;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string answer = ""; 
           

            foreach (string word in words)
            {
               
                if (words[words.Length - 1] != word && word.Trim().Length > 0)
                {
                    answer += $"{word.Trim()} ";
                }
                else if (word.Trim().Length > 0)
                {
                    answer += $"{word.Trim()}.";
                }
            }
            return answer;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0) 
            {
                return new double[] { };
            }
            double[] doubles = elements.ToArray();
            var answer = new List<double>();
            for(int i = 0; i < doubles.Length; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    answer.Add(doubles[i]);
                }
            }
            return answer.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool answer = false;
            if (nums == null || nums.Length <= 1)
            {
                return false;
            }
            for (int x = 0; x < nums.Length; x++)
            {
              for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[x] + nums[i] == targetNumber && x != i)
                    {
                       answer = true;
                    }
            }
            }
            return answer;
           
        }
    }
}

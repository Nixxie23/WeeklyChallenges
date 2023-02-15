using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else 
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var oddsList = new List<int>();
            if (numbers != null)
            {
                foreach (int n in numbers)
                {
                    if (n % 2 != 0)
                    {
                        oddsList.Add(n);
                    }
                }
                int sumOfOddNumbers = oddsList.Sum();
                return sumOfOddNumbers % 2 != 0;
            }
            else return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            foreach(var letter in password)
            {
                if (char.IsLower(letter))
                    {
                    containsLower = true;
                }
              
                if (char.IsUpper(letter)) 
                    {
                    containsUpper = true;
                }
           
                if (char.IsNumber(letter))
                {
                    containsNumber = true;
                }
               

            }
            if (containsUpper && containsLower && containsNumber)
            {
                return true;
            }
            else 
                return false; 
            



        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            else
                return 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            
           return nums == null ? 0 : nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var oddsBelow100 = new int[50]{ 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99};
                      
            return oddsBelow100;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] =  (words[i].ToUpper());
            }
        }
    }
}

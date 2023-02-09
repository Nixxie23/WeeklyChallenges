using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool isTrue = char.IsLetter(c);
            return isTrue;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int length = vals.Length;
            bool isEven = (length % 2 == 0);
            return isEven;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int one = str1.Length;
            int two = str2.Length;
            if (one < two)
            {
                return one;
            }
            else
                return two;
        }

        public int Sum(int[] numbers)
        {
            int numSum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numSum += numbers[i];
                }
                return numSum;
            }
            else
                return 0;
        }

        public int SumEvens(int[] numbers)
        {
            int numSum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        numSum += numbers[i];
                        }
                }
                return numSum;
            }
            else
                return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int numSum = 0;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    numSum += numbers[i];
                }
                bool isOdd = (numSum % 2 != 0);
                return isOdd;
            }
            else return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long oddSum = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddSum += 1;
                }
                            }
            return oddSum;
        }
    }
}

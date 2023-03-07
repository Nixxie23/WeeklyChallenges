using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           return (numbers.Where(number => number % 2 == 0).Sum()) - (numbers.Where(number => number % 2 != 0).Sum());
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringList = new List<int> {str1.Count(), str2.Count(), str3.Count(), str4.Count()};
           return stringList.Min();
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>() { number1, number2, number3, number4};
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
                if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
           return double.TryParse(input, out var num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var isNullMoreCommon = (objs.Where(obj => obj == null).Count()) - (objs.Where(obj => obj != null).Count());
            if (isNullMoreCommon > 0)
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else if (numbers.Where(num => num % 2 == 0).Count() == 0)
            {
                return 0;
            }
            else
                return numbers.Where(num => num % 2 == 0).Average();
            

        }

        public int Factorial(int number)
        { if (number >= 0)
            {
                int answer = 1;
                for (int x = number; x > 0; x--)
                {
                    answer = x * answer;
                }
                return answer;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}

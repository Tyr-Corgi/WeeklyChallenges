using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //Jeremy's favorite
            return char.IsLetter(c);

            //Jeremy least favorite
            //var alpha = "abcdefghijklmnopqrstuvwxyz";
            //return alpha.Contains(char.ToLower(c));


        }


    public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0); 
        }
            
        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}
            //double min = 0;
            //double max = 0;

            //foreach (var num in numbers) 
            //{
            //    if (num >= max) 
            //    {
            //        max = num;
            //    }
            //    if (num <= min)
            //    {
            //        min = num;
            //    }
            //    if (numbers.Count() <= 1)
            //    {
            //        min = num;
            //    }
            //}
            //return min + max;
            return (numbers == null || numbers.Count() == 0) ? 0 : numbers.Min() + numbers.Max();

            //(Math.Min) + (Math.Max)
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //if (str1.Length < str2.Length)
            //{
            //    return str1.Length + str2.Length;
            //}

            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            //Best practice
            //Null COndition ? 
            // Null Coalescing ??
            return numbers?.Sum() ?? 0;

            //var sum = 0;
            //if (numbers == null)
            //{
            //    return 0;
            //}

            //for (var i =0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //return sum;
        }

        public int SumEvens(int[] numbers)
        {
            //Best Practise 
            return numbers?.Where(x => x % 2 == 0).Sum() ?? 0;
            
            //if (numbers == null)
            //{
            //    return 0;
            //}

            //var evenSum = 0;

            //for (var i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenSum += numbers[i];
            //    }
            //}
            //return evenSum;
        } 

        public bool IsSumOdd(List<int> numbers)
        {
            //Best Practise
            return (numbers == null) ? false : (numbers.Sum() % 2 != 0);

            //if (numbers == null)
            //{
            //    return false;
            //}

            //var sum = 0;

            //foreach ( var num in numbers) 
            //{
            //    sum += num;
            //}
            //return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number <= 0) ? 0 :number / 2;

            //Best Practise when returning a single value
            //if (number <= 0)
            //    return 0;
            //else
            //    return number / 2;
        }
    }
}

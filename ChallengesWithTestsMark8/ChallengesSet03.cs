using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //for (var i = 0; i < vals.Length; i++)
            //{
            //    if (vals[i] == false)
            //    {
            //        return true;
            //    }
            //}
            //return false;

            //Jeremy's refactor
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //Jeremy's null check
            //if (numbers == null)
            //{
            //    return false;
            //}

            //var odds = new List<int>();
            //foreach (var n in numbers)
            //{
            //    if (n % 2 != 0)
            //    {
            //        odds.Add(n);
            //    }
            //}
            //var sumOdds = odds.Sum();
            //return (sumOdds % 2 != 0);

            //Jeremy's refactor
            return (numbers == null) ? false : numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //var isLower = false;
            //var isUpper = false;
            //var isNumber = false;

            //for (var i = 0; i < password.Length; i++)
            //{
            //    if (char.IsLower(password[i]))
            //    {
            //        isLower = true;
            //    }

            //    if (char.IsUpper(password[i]))
            //    {
            //        isUpper = true;
            //    }
            //    if (char.IsNumber(password[i]))
            //    {
            //        isNumber = true;
            //    }
            //}
            //if (isLower == true && isUpper == true && isNumber == true) //Alec's way (isLower && isUpper && isNumber)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //Jeremy's refactor
            return (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsNumber));
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];
            //Jeremy's refactor
            return val.First();

        }

        public char GetLastLetterOfString(string val)
        {
            //Jeremy's long way
            //return val[val.Length - 1];

            return val.Last();

            ////Jeremy's Refactor
            //return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //if ( divisor == 0 )
            //{
            //    return 0;
            //}
            //return dividend / divisor;

            //Jeremy's Refactor
            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //return nums[nums.Length - 1] - nums[0];

            //Jeremy's long way
            //return nums[^ 1] - nums[0];
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            //var oddsList = new List<int>();
            //for (var i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        oddsList.Add(i);
            //    }
            //}
            //return oddsList.ToArray();

            //Jeremys Refactor
            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}

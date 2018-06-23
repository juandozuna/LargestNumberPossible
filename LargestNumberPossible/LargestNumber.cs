using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNumberPossible
{
    public class LargestNumber
    {
        public string GetLargest(int[] nums)
        {
            if (PossibleToGetLargest(nums))
                return GetLargestAlgorithm(nums);
            return "0";
        }

        private string GetLargestAlgorithm(int[] nums){
            string ret = "";

            var arr = new List<String>();

            foreach (var n in nums)
            {
                arr.Add(n.ToString());
            }

            arr.Sort(new CustomStringComparator());
            for (int i = 0; i < arr.Count; i++)
            {
                ret += arr[i];
            }
            return ret;
        }

        private bool PossibleToGetLargest(int[] nums) =>
            (nums.Sum() <= 0 || nums.Any(n => n < 0)) ? false : true;
          
    }

    public class CustomStringComparator : Comparer<String>
    {
        public override int Compare(string a, string b)
        {
            string sum1 = a + b;
            string sum2 = b + a;
            return sum2.CompareTo(sum1);
        }
    }

}
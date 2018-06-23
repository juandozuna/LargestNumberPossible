using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNumberPossible
{
    public class LargestNumber
    {
        public string GetLargest(int[] nums)
        {
            string ret = "";
            if (nums.Length <= 0)
                return "";
            
            int zerCount = 0;
            var arr = new List<String>();

            foreach (var n in nums) 
            {
                if (n < 0) return "";
                if (n == 0) zerCount++;
                arr.Add(n.ToString());
            }
            if (zerCount == nums.Length) return "0";

            arr.Sort(new CustomStringComparator());
            for (int i = 0; i < arr.Count; i++)
            {                    
                ret += arr[i];
            }
            return ret;
        }
          
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
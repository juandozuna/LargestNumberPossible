using System;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            var s = solution.LargestNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            Console.WriteLine("The Answer is: {0}", s);
        }


    }

    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            int size = nums.Length;
            int[] a = nums;
            string max = "0";
            string number = "0";
            Permutation(a, size, ref max, ref number);

            return number;
        }


        private void Permutation(int[] a, int size, ref string max, ref string number)
        {
            // if size becomes 1 then prints the obtained
            // permutation
            if (size == 1)
            {
                string t = "";
                for (int i = 0; i < a.Length; i++)
                {
                    t += a[i].ToString();
                }
                string num = t;
                if (num.CompareTo(max) == 1)
                {
                    number = t;
                    max = num;
                }
            }

            for (int i = 0; i < size; i++)
            {
                Permutation(a, size - 1, ref max, ref number);

                // if size is odd, swap first and last
                // element
                if (size % 2 == 1)
                {
                    int temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;
                }
                // If size is even, swap ith and last
                // element
                else
                {
                    int temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;
                }
            }
        }

    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Arrays_Hashing
{
    public class TwoSumLeetcode1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            { 
                int diff = target - nums[i];
                if(dict.ContainsKey(diff))
                    return new int[] { dict[diff], i};

                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }

            return null;
        }

        public static void Test()
        {
            int[] nums10 = { 2, 7, 4, 11, 15, 3 };
            int target10 = 19;

            Console.WriteLine(TwoSum(nums10, target10).ArrayToString());


            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;

            Console.WriteLine(TwoSum(nums1, target1).ArrayToString());

            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;

            Console.WriteLine(TwoSum(nums2, target2).ArrayToString());

            int[] nums3 = { 3, 3 };
            int target3 = 6;

            Console.WriteLine(TwoSum(nums3, target3).ArrayToString());


        }

    }
}

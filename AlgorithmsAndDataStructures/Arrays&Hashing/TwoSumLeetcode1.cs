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
            int[] ans = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        ans[0] = i;
                        ans[1] = j;
                        return ans;
                    }
                }
            }

            return ans;

        }

        public static void Test()
        {
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

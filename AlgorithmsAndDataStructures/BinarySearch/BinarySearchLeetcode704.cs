using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.BinarySearch
{
    public class BinarySearchLeetcode704
    {
        public static int Search(int[] nums, int target)
        {
            int leftEdge = 0;
            int rightEdge = nums.Length - 1;

            while (leftEdge <= rightEdge)
            {
                int mid = leftEdge + (rightEdge - leftEdge) / 2;

                if (nums[mid] == target)
                    return mid;

                if (target > nums[mid])
                    leftEdge = mid + 1;
                else
                    rightEdge = mid - 1;
            }
            return -1;
        }


        public static void Test()
        {
            int[] nums1 = { -1, 0, 3, 5, 9, 12 };
            int target1 = 9;

            Console.WriteLine(Search(nums1, target1));

            int[] nums2 = { -1, 0, 3, 5, 9, 12 };
            int target2 = 2;

            Console.WriteLine(Search(nums2, target2));
        }
    }
}

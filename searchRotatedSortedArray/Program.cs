﻿using System;

namespace searchRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Solution();
            int t = 3;
            int[] nums = new int[]{4,5,6,7,0,1,2,3};
            Console.WriteLine("search in rotated sorted array {0} : {1}", t, obj.Search(nums, t));
        }
    }
    public class Solution {
        public int Search(int[] nums, int target) {
            int n = nums.Length;
            if (n == 0) return -1;
            int left = 0, right = n - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < nums[right]) {
                    if (nums[mid] < target && target <= nums[right]) left = mid + 1;
                    else right = mid - 1;
                } 
                // rotated in the right side
                // no duplicates
                else {
                    if (nums[left] <= target && target < nums[mid]) right = mid - 1;
                    else left = mid + 1;
                }
            }
            return -1;
        }
    }
}

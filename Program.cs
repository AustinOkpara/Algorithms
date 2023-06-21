﻿using System.Reflection.Metadata.Ecma335;

namespace Algos_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Test for Algo 1
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 7;

            Solution solution = new Solution();
            int index = solution.Search(nums, target);

            Console.WriteLine("Target index: " + index);



            // Test For Algo 2
            //int totalVersions = 10;

            //FirstBad badVersion = new FirstBad();
            //int firstBadVersion = badVersion.FirstBadVersion(totalVersions);

            //Console.WriteLine("First bad version: " + firstBadVersion);


            //Test for Algo 3
            int[] num = { 1, 3, 5, 6 };
            int targets = 4;

            ALGO3 search = new ALGO3();
            int indexx = search.SearchInsert(num, targets);

            Console.WriteLine("Target index: " + indexx);

            // Test for Algo 4
            int[] numss = { -4, -2, 0, 2, 4 };
            AlGO4 sortedSquares = new AlGO4();
            int[] result = sortedSquares.SortedSquares(numss);
            Console.WriteLine(string.Join(", ", result));

        }
    }
    // Algo 1
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }


    // Algo 2

    //public class FirstBad
    //{
    //    public  int FirstBadVersion(int n)
    //    {
    //        int left = 1;
    //        int right = n;


    //        while (left < right)
    //        {
    //            int mid = left + (right - left) / 2;

    //            if (IsBadVersion(mid))
    //            {
    //                right = mid;
    //            }
    //            else
    //            {
    //                left = mid + 1;
    //            }
    //        }

    //        return left;
    //    }
    //}

    // Algo 3
    public class ALGO3
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }
    }
    //Algo 4
    public class AlGO4
    {
        public int[] SortedSquares(int[] nums)
        {
            int[] newArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                newArray[i] = nums[i] * nums[i];
            }
            Array.Sort(newArray);

            return newArray;
        }

        
    }

}

namespace Algos_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 7;

            Solution solution = new Solution();
            int index = solution.Search(nums, target);

            Console.WriteLine("Target index: " + index);




            //int totalVersions = 10;

            //FirstBad badVersion = new FirstBad();
            //int firstBadVersion = badVersion.FirstBadVersion(totalVersions);

            //Console.WriteLine("First bad version: " + firstBadVersion);


            int[] num = { 1, 3, 5, 6 };
            int targets = 4;

            Search search = new Search();
            int indexx = search.SearchInsert(num, targets);

            Console.WriteLine("Target index: " + indexx);

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

    //public class FirstBad : Program
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
    public class Search
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
}

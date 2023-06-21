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
        }
    }

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
}
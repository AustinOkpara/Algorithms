using System.Reflection.Metadata.Ecma335;

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

            //Test for Algo 5
            int[] number = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            ALGO5 answer = new ALGO5();
            answer.Rotate(nums, k);

            Console.WriteLine(string.Join(", ", number));

            //Test for Algo 6
            int[] numbers = { 0, 1, 0, 3, 12 };
            ALGO6 soln = new ALGO6();
            soln.MoveZeroes(nums);

            foreach (int numm in nums)
            {
                Console.Write(numm + " ");
            }

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
    //    public int FirstBadVersion(int n)
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

    // Algo 5
    public class ALGO5
    {
        public void Rotate(int[] nums, int k)
        {

            int[] temp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {

                temp[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = temp[i];
            }
            return;
        }

    }

    //ALGO6
    public class ALGO6
    {
        public void MoveZeroes(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            while (count < nums.Length)
            {
                nums[count] = 0;
                count++;
            }

        }
    }


    //Algo7
    public class ALGO7
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }


            }
            return new int[0];
        }
    }

    //Algo 8
    public class ALGO8
    {
        public void ReverseString(char[] s)
        {
            int length = s.Length;

            for (int i = 0; i < length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[length - i - 1];
                s[length - i - 1] = temp;
            }
        }

    }

    //Algo 9
    public class ALGO9
    {
        public string ReverseWords(string s)
        {

            string[] words = s.Split(' ');

            // Reverse each word
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            return string.Join(" ", words);
        }
    }
}
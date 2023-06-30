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

    // ALGO 10
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
            this.val = val;
            this.next = next;
      }

    }




    public class ALGO10
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;

        }
    }

    public class ALGO11
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode slow = dummy;
            ListNode fast = dummy;

            // Move the fast pointer n steps ahead
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;

            return dummy.next;

        }
    }

    //Algo 12

    public class ALGO12
    {
        public int LengthOfLongestSubstring(string s)
        {

            int len = s.Length;
            int start = 0, end = 0, maxLength = 0;
            HashSet<char> uniqueChars = new HashSet<char>();

            while (end < len)
            {
                if (uniqueChars.Contains(s[end]))
                {
                    uniqueChars.Remove(s[start]);
                    start++;
                }
                else
                {
                    uniqueChars.Add(s[end]);
                    maxLength = Math.Max(maxLength, end - start + 1);
                    end++;
                }

            }
            return maxLength;
        }
    }

    //ALGO13

    public class ALGO13
    {
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] count = new int[26];

            // Count characters in s1
            foreach (char c in s1)
                count[c - 'a']++;

            int start = 0, end = 0, len = s1.Length;

            while (end < s2.Length)
            {
                if (count[s2[end] - 'a'] > 0)
                {
                    count[s2[end] - 'a']--;
                    end++;
                    len--;

                    if (len == 0)
                        return true;
                }
                // Shrink the window
                else if (start < end)
                {
                    count[s2[start] - 'a']++;
                    start++;
                    len++;
                }
                // Move both start and end pointers
                else
                {
                    start++;
                    end++;
                }
            }

            return false;

        }
    }

    public class ALGO14
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int rows = image.Length;
            int cols = image[0].Length;
            int sourceColor = image[sr][sc];

            if (sourceColor == color)
                return image;

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((sr, sc));
              int[][] directions = { new int[] { -1, 0 }, new int[] { 1, 0 },
              new int[] { 0, -1 }, new int[] { 0, 1 } };

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();
                image[row][col] = color;

                foreach (var dir in directions)
                {
                    int newRow = row + dir[0];
                    int newCol = col + dir[1];

                    if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && image[newRow][newCol] == sourceColor)
                    {
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }

            return image;
        }


    }

    public class ALGO15
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            int maxArea = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int area = CalculateArea(grid, i, j);
                        maxArea = Math.Max(maxArea, area);
                    }
                }
            }

            return maxArea;
        }

        private int CalculateArea(int[][] grid, int row, int col)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            if (row < 0 || row >= rows || col < 0 || col >= cols || grid[row][col] == 0)
                return 0;

            grid[row][col] = 0;

            int area = 1;

            area += CalculateArea(grid, row - 1, col); // Up
            area += CalculateArea(grid, row + 1, col); // Down
            area += CalculateArea(grid, row, col - 1); // Left
            area += CalculateArea(grid, row, col + 1); // Right

            return area;
        }


    }

    //Algo 16
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
                return t2;
            if (t2 == null)
                return t1;

            TreeNode mergedNode = new TreeNode(t1.val + t2.val);
            mergedNode.left = MergeTrees(t1.left, t2.left);
            mergedNode.right = MergeTrees(t1.right, t2.right);

            return mergedNode;
        }
    }

    //Algo 17
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node(int val)
        {
            this.val = val;
        }


        public Node Connect(Node root)
        {
            if (root == null)
                return null;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currNode = queue.Dequeue();

                    if (i < levelSize - 1)
                        currNode.next = queue.Peek();

                    if (currNode.left != null)
                        queue.Enqueue(currNode.left);
                    if (currNode.right != null)
                        queue.Enqueue(currNode.right);
                }
            }

            return root;
        }
    }

    //Algo 18

    public class ALGO18
    {
        public int[][] UpdateMatrix(int[][] mat)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;

            int[][] directions = { new int[] { -1, 0 }, new int[] { 1, 0 },
            new int[] { 0, -1 }, new int[] { 0, 1 } };

            Queue<int[]> queue = new Queue<int[]>();

         
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i][j] == 0)
                        queue.Enqueue(new int[] { i, j });
                    else
                        mat[i][j] = int.MaxValue;
                }
            }

            while (queue.Count > 0)
            {
                int[] cell = queue.Dequeue();
                int row = cell[0];
                int col = cell[1];
                foreach (int[] direction in directions)
                {
                    int newRow = row + direction[0];
                    int newCol = col + direction[1];

                    if (newRow >= 0 && newRow < rows && newCol >= 0 &&
                    newCol < cols && mat[row][col] + 1 < mat[newRow][newCol])
                    {
                        mat[newRow][newCol] = mat[row][col] + 1;
                        queue.Enqueue(new int[] { newRow, newCol });
                    }
                }
            }

            return mat;

        }
    }

    //Algo 19

    public class ALGO19
    {
        public int OrangesRotting(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            int freshCount = 0;
            int minutes = 0;

            Queue<int[]> queue = new Queue<int[]>();

       
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 2)
                        queue.Enqueue(new int[] { i, j });
                    else if (grid[i][j] == 1)
                        freshCount++;
                }
            }

            if (freshCount == 0)
                return 0;

            queue.Enqueue(null);

               int[][] directions = { new int[] { -1, 0 }, new int[] { 1, 0 },
               new int[] { 0, -1 }, new int[] { 0, 1 } };
            while (queue.Count > 0)
            {
                int[] cell = queue.Dequeue();

                if (cell == null)
                {
                    if (queue.Count > 0)
                        queue.Enqueue(null);
                    minutes++;
                }
                else
                {
                    int row = cell[0];
                    int col = cell[1];

                    foreach (int[] direction in directions)
                    {
                        int newRow = row + direction[0];
                        int newCol = col + direction[1];

                        if (newRow >= 0 && newRow < rows && newCol >= 0
                        && newCol < cols && grid[newRow][newCol] == 1)
                        {
                            grid[newRow][newCol] = 2;
                            freshCount--;
                            queue.Enqueue(new int[] { newRow, newCol });
                        }
                    }
                }
            }

            if (freshCount == 0)
                return minutes - 1;
            else
                return -1;
        }
    }

    // Algo 20
    public class ALGO20
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummyHead = new ListNode(0); 
            ListNode current = dummyHead;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            // Append remaining nodes
            if (list1 != null)
                current.next = list1;
            else if (list2 != null)
                current.next = list2;

            return dummyHead.next;

        }
    }

    //Algo 21

    public class ALGO21
    {
        public ListNode ReverseList(ListNode head)
        {

            if (head == null || head.next == null)
                return head;

            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
    //Algo 22

    public class ALGO22
    {
        public IList<IList<int>> Combine(int n, int k)
        {

            IList<IList<int>> combinations = new List<IList<int>>();
            List<int> currentCombination = new List<int>();

            Backtrack(1, n, k, currentCombination, combinations);

            return combinations;
        }

        private void Backtrack(int start, int n, int k, List<int> currentCombination, IList<IList<int>> combinations)
        {
            if (currentCombination.Count == k)
            {
                combinations.Add(new List<int>(currentCombination));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                currentCombination.Add(i);
                Backtrack(i + 1, n, k, currentCombination, combinations);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

    }
    //Algo 23


}
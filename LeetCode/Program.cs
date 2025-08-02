
Solution s = new Solution();
Console.WriteLine(s.FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2));
Console.WriteLine(s.FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        // You just need to implement a heap in memory. Period...
        // The array needs to be of size k. 

        //Let's try this approach. Start from the last element and swap with the parent if is larger.

        //Parent = (i / 2) - 1
        for (int i = nums.Length - 1; i > 0; i--)
        {
            var parentIndex = i;
            var newParentIndex = (i - 1) / 2;
            // parentIndex = parentIndex >= 0 ? parentIndex : 0;
            while (nums[parentIndex] > nums[newParentIndex])
            {
                var temp = nums[parentIndex];
                nums[parentIndex] = nums[newParentIndex];
                nums[newParentIndex] = temp;

                temp = newParentIndex;
                newParentIndex = (newParentIndex - 1) / 2;
                parentIndex = temp;
            }
        }

        return nums[k - 1];
    }
}
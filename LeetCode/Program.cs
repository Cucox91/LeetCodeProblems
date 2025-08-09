using LeetCode;

Solution s = new Solution();

var result1 = s.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
foreach (var item in result1)
{
    Utils.PrintCollection(item);
    Console.WriteLine();
}
// Utils.PrintCollection(s.ThreeSum(new int[] { 0, 1, 1 }));
// Utils.PrintCollection(s.ThreeSum(new int[] { 0, 0, 0 }));

public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> examples = new List<List<int>>();
        // Dictionary<int, int> values = new Dictionary<int, int>();
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     values.Add(nums[i], i);
        // }

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                if (nums[i] == -nums[j] - nums[j])
                {
                    if (nums.Contains(nums[j]) && nums.Contains(-nums[j]))
                    {
                        examples.Add(new List<int> { nums[i], nums[j], -nums[j] });
                    }
                }
            }
        }


        return examples;
    }
}
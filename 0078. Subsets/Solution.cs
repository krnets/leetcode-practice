using System.Collections.Generic;

public class Solution
{
    List<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> Subsets(int[] nums)
    {
        BackTrack(0, new List<int>(), nums);
        return res;
    }

    private void BackTrack(int start, List<int> currList, int[] nums)
    {
        res.Add(new List<int>(currList));

        for (int i = start; i < nums.Length; i++)
        {
            currList.Add(nums[i]);
            BackTrack(i + 1, currList, nums);
            currList.RemoveAt(currList.Count - 1);
        }
    }
}
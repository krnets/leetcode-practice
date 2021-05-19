/*using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    List<IList<int>> listSubsets = new List<IList<int>>();

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        BackTrack(nums, 0, new List<int>());

        var setJoinedStr = new HashSet<string>();
        var resultSet = new HashSet<IList<int>>();

        foreach (IList<int> list in listSubsets)
        {
            var joinedStr = string.Join(",", list);

            if (setJoinedStr.Contains(joinedStr))
                continue;

            setJoinedStr.Add(joinedStr);
            resultSet.Add(list);
        }

        return resultSet.ToList();
    }

    private void BackTrack(int[] nums, int start, List<int> currList)
    {
        listSubsets.Add(new List<int>(currList));

        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
                continue;

            currList.Add(nums[i]);
            BackTrack(nums, i + 1, currList);
            currList.RemoveAt(currList.Count - 1);
        }
    }
}*/


/*using System;
using System.Collections.Generic;

public class Solution
{
    List<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        BackTrack(nums, 0, new List<int>());

        return res;
    }

    private void BackTrack(int[] nums, int start, List<int> currList)
    {
        res.Add(new List<int>(currList));

        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1])
                continue;

            currList.Add(nums[i]);
            BackTrack(nums, i + 1, currList);
            currList.RemoveAt(currList.Count - 1);
        }
    }
}*/

using System;
using System.Collections.Generic;

public class Solution
{
    List<IList<int>> res = new List<IList<int>>();

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        BackTrack(nums, 0, new List<int>());

        return res;
    }

    private void BackTrack(int[] nums, int start, List<int> currList)
    {
        res.Add(new List<int>(currList));

        for (int i = start; i < nums.Length; i++)
        {
            if (i == start || nums[i - 1] != nums[i])
            {
                currList.Add(nums[i]);
                BackTrack(nums, i + 1, currList);
                currList.RemoveAt(currList.Count - 1);
            }
        }
    }
}
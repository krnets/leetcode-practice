/*public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        int prev = -k - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (i - prev - 1 < k)
                    return false;

                prev = i;
            }
        }

        return true;
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        var oneIndices = new List<int>();

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] == 1)
                oneIndices.Add(i);

        for (int i = 1; i < oneIndices.Count; i++)
            if ((oneIndices[i] - oneIndices[i - 1] - 1) < k)
                return false;

        return true;
    }
}
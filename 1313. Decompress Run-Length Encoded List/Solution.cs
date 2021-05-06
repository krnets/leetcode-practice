/*using System.Collections.Generic;

public class Solution
{
    public int[] DecompressRLElist(int[] nums)
    {
        var list = new List<int>();

        for (int i = 0; i < nums.Length / 2; i++)
        {
            int freq = nums[2 * i];
            int val = nums[2 * i + 1];

            while (freq > 0)
            {
                list.Add(val);
                freq--;
            }
        }

        return list.ToArray();
    }
}*/

using System.Collections.Generic;

public class Solution
{
    public int[] DecompressRLElist(int[] nums)
    {
        var list = new List<int>();

        for (int i = 0; i < nums.Length; i += 2)
        {
            int freq = nums[i];
            int val = nums[i + 1];

            while (freq > 0)
            {
                list.Add(val);
                freq--;
            }
        }

        return list.ToArray();
    }
}
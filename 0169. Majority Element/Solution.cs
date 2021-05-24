/*using System.Collections.Generic;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int threshold = nums.Length / 2;
        var freqMap = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (freqMap.ContainsKey(num))
                freqMap[num]++;
            else freqMap.Add(num, 1);

            if (freqMap[num] > threshold)
                return num;
        }

        return -1;
    }
}*/

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
                candidate = num;

            count += (candidate == num) ? 1 : -1;
        }

        return candidate;
    }
}
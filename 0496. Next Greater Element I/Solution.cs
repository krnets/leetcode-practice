using System.Collections.Generic;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var map = new Dictionary<int, int>();
        var stack = new Stack<int>();

        foreach (int num in nums2)
        {
            while (stack.Count > 0 && stack.Peek() < num)
                map.Add(stack.Pop(), num);

            stack.Push(num);
        }

        for (int i = 0; i < nums1.Length; i++)
            nums1[i] = map.GetValueOrDefault(nums1[i], -1);

        return nums1;
    }
}
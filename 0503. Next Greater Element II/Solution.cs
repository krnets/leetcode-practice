using System;
using System.Collections.Generic;

public class Solution
{
    public int[] NextGreaterElements(int[] nums)
    {
        var stack = new Stack<int>();
        int n = nums.Length;
        var res = new int[n];
        Array.Fill(res, -1);

        for (int i = 0; i < 2 * n; i++)
        {
            while (stack.Count > 0 && nums[stack.Peek()] < nums[i % n])
            {
                res[stack.Pop()] = nums[i % n];
            }

            stack.Push(i % n);
        }

        return res;
    }
}
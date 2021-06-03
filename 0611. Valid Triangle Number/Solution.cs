using System;

public class Solution
{
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);
        int triplets = 0;

        for (int i = 2; i < nums.Length; i++)
        {
            int leftPos = 0;
            int rightPos = i - 1;

            while (leftPos < rightPos)
            {
                int x = nums[leftPos] + nums[rightPos];

                if (nums[i] < x)
                {
                    triplets += rightPos - leftPos;
                    rightPos--;
                }
                else leftPos++;
            }
        }

        return triplets;
    }
}
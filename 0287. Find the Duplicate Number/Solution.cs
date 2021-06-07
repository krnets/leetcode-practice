/*public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        var slow = 0;
        var fast = 0;
        var head = 0;

        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);


        do
        {
            slow = nums[slow];
            head = nums[head];
        } while (slow != head);

        return slow;
    }
}*/

/*
public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        var slow = nums[0];
        var fast = slow;

        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (slow == fast)
                break;
        }

        slow = nums[0];

        while (slow != fast)
        {
            fast = nums[fast];
            slow = nums[slow];
        }

        return fast;
    }
}
*/


using System;

public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        var min = int.MaxValue;
        var max = int.MinValue;

        foreach (var x in nums)
        {
            min = Math.Min(min, x);
            max = Math.Max(max, x);
        }

        var arr = new int[max - min + 1];

        foreach (var x in nums)
        {
            arr[x - min]++;

            if (arr[x - min] > 1)
                return x;
        }

        return nums[0];
    }
}
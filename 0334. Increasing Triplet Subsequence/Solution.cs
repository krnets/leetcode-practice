/*public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in nums)
        {
            if (num <= smallest)
            {
                smallest = num;
            }
            else if (num <= secondSmallest)
            {
                secondSmallest = num;
            }
            else return true;
        }

        return false;
    }
}*/

using System;

/*public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int min = int.MaxValue;
        int secondMin = int.MaxValue;

        foreach (int num in nums)
        {
            if (num > secondMin)
                return true;

            min = Math.Min(min, num);

            if (num > min)
                secondMin = num;
        }

        return false;
    }
}*/

public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        int minA = int.MaxValue;
        int minB = int.MaxValue;

        foreach (int num in nums)
        {
            if (num > minB)
                return true;

            minA = Math.Min(minA, num);

            if (num > minA)
                minB = num;
        }

        return false;
    }
}
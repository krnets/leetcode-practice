/*public class Solution
{
    public int ArraySign(int[] nums)
    {
        bool hasZero = false;
        int countMinus = 0;

        foreach (int num in nums)
        {
            if (num == 0)
            {
                hasZero = true;
                break;
            }

            if (num < 0)
            {
                countMinus++;
            }
        }

        return hasZero ? 0 : countMinus % 2 == 0 ? 1 : -1;
    }
}*/

/*
public class Solution
{
    public int ArraySign(int[] nums)
    {
        int r = 1;

        foreach (int num in nums)
            r *= num < 0 ? -1 : num == 0 ? 0 : 1;

        return r;
    }
}
*/

using System.Linq;

public class Solution
{
    public int ArraySign(int[] nums)
    {
        return nums.Aggregate(1, (acc, cur) => acc * (cur < 0 ? -1 : cur == 0 ? 0 : 1));
    }
}

/*
public class Solution
{
    public int ArraySign(int[] nums)
    {
        return nums.Aggregate(1, (acc, cur) => acc * (cur < 0 ? -1 : cur > 0 ? 1 : 0));
    }
}
*/


/*public class Solution
{
    public int ArraySign(int[] nums)
    {
        int r = 1;

        foreach (int num in nums)
        {
            if (num == 0)
                return 0;

            r *= num < 0 ? -1 : 1;
        }

        return r;
    }
}*/